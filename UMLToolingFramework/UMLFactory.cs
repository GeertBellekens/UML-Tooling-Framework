using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;

using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML {

  public abstract class UMLFactory {
    private static Dictionary<UMLModel, UMLFactory> instances = 
      new Dictionary<UMLModel,UMLFactory>();

    private static void addFactory(UMLModel model, UMLFactory factory) {
      if (!instances.ContainsKey(model)) {
        instances.Add(model, factory);
      }
    }

    /// returns the factory that corresponds to the given model
    protected static UMLFactory getFactory(UMLModel model) {
      UMLFactory instance = null;
      instances.TryGetValue(model, out instance);
      return instance;
    }

    /// returns the singleton instance of the factory
    public static UMLFactory getInstance(UMLModel model) {
      UMLFactory instance = getFactory(model);
      if (instance == null) {
        instance = model.factory;
      }
      return instance;
    }
    /// <summary>
    /// returns the first instance of the factory.
    /// To be used when only one factory exists
    /// </summary>
    /// <returns>the first (and only?) instance of the factory</returns>
    public static UMLFactory getInstance()
    {
    	if (instances.Count > 0)
    	{
    		return instances.Values.ElementAt(0);
    	}else
    	{
    		return null;
    	}
    }

    public UMLModel model { get; set; }

    public UMLFactory(UMLModel model) {
      this.model = model;
      UMLFactory.addFactory(model, this);
    }

    /// creates a new UML element based on the given object to wrap
    public abstract UML.Classes.Kernel.Element createElement
      (Object objectToWrap);

    /// creates a new PrimitiveType based on the given object to wrap
    public abstract UML.Classes.Kernel.PrimitiveType createPrimitiveType
      (Object objectToWrap);
    
    public abstract UML.Diagrams.Diagram createDiagram(object objectToWrap);

    /// returns a collection of Elements based on the collection of objects to
    /// wrap
    public ICollection<UML.Classes.Kernel.Element> createElements
      (IEnumerable objectsToWrap) 
    {
      List<UML.Classes.Kernel.Element> elements = 
        new List<UML.Classes.Kernel.Element>();
      foreach (Object objectToWrap in objectsToWrap) {
        elements.Add(this.createElement(objectToWrap));
      }
      return elements;
    }
    
    /// create a new element as owned element of the given owner
    public abstract T createNewElement<T>(UML.Classes.Kernel.Element owner, 
                                          String name) 
      where T : class, UML.Classes.Kernel.Element;

    public abstract UML.Profiles.Stereotype createStereotype
      (UML.Classes.Kernel.Element owner, String name);

    public abstract T createNewDiagram<T>
      (UML.Classes.Kernel.Element owner, String name) where T:class,UML.Diagrams.Diagram;
    
    public abstract UML.Profiles.TaggedValue createNewTaggedValue(UML.Classes.Kernel.Element owner, string name);

    /// clones a diagram cloning all diagramElements and their related 
    /// elements
    public UML.Diagrams.Diagram cloneDiagram(UML.Classes.Kernel.Element owner, 
                                             UML.Diagrams.Diagram diagram) 
    {
          Dictionary<UML.Diagrams.DiagramElement, UML.Diagrams.DiagramElement> 
            diagramElementsMap = new Dictionary<UML.Diagrams.DiagramElement, 
                                                UML.Diagrams.DiagramElement>();
          Dictionary<UML.Classes.Kernel.Element, UML.Classes.Kernel.Element>
            elementsMap = new Dictionary<UML.Classes.Kernel.Element, 
                                         UML.Classes.Kernel.Element>();

          UML.Diagrams.Diagram clonedDiagram = null;

          if (diagram is UML.Diagrams.ClassDiagram)
          {clonedDiagram = this.createNewDiagram<UML.Diagrams.ClassDiagram>(owner, diagram.name);}

          else if (diagram is UML.Diagrams.SequenceDiagram)
          { clonedDiagram = this.createNewDiagram<UML.Diagrams.SequenceDiagram>(owner, diagram.name); }

          clonedDiagram.name = diagram.name;
          clonedDiagram.width   = diagram.width;
          clonedDiagram.height  = diagram.height;
          clonedDiagram.comment = diagram.comment;

          List<UML.Diagrams.DiagramElement> diagramElements = 
            diagram.diagramElements.ToList();
          diagramElements = this.sortDiagramElements(diagramElements);

          foreach( UML.Diagrams.DiagramElement diagramElement in diagramElements ) 
          {
            UML.Diagrams.DiagramElement clonedDiagramElement = 
              this.cloneDiagramElement(clonedDiagram,diagramElement, elementsMap);
            if( clonedDiagramElement != null ) {
               diagramElementsMap.Add(diagramElement, clonedDiagramElement);
               elementsMap.Add( diagramElement.element, 
                                clonedDiagramElement.element);
            }
          }

          foreach( UML.Classes.Kernel.Element element in elementsMap.Keys) {
            foreach( UML.Classes.Kernel.Element subElement in 
                     element.ownedElements ) 
            {
              this.cloneElement(elementsMap[element], subElement, elementsMap, 
                                true);
            }
          }
          return clonedDiagram;
    }

    /// sort the diagram elements
    /// First all diagram elements that do not represent a classifier
    /// If both of them are classifiers then the target of the directed 
    /// relationships should be first
    private List<UML.Diagrams.DiagramElement> sortDiagramElements
            (List<UML.Diagrams.DiagramElement> diagramElements)
    {
      List<UML.Diagrams.DiagramElement> sortedDiagramElements = 
        new List<UML.Diagrams.DiagramElement>();
      foreach( UML.Diagrams.DiagramElement diagramElement in diagramElements ) 
      {
        if( sortedDiagramElements.Count == 0 ) {
          sortedDiagramElements.Add(diagramElement);
        } else {
          bool inserted = false;
          for( int i = 0; i< sortedDiagramElements.Count;i++ ) {
            UML.Diagrams.DiagramElement sortedDiagramElement = 
              sortedDiagramElements[i];
            if( !inserted ) {
              if( !inserted 
                  && sortedDiagramElement.element is 
                     UML.Classes.Kernel.Relationship
                  && !( diagramElement.element is 
                        UML.Classes.Kernel.Relationship) )
              {
                sortedDiagramElements.Insert(i, diagramElement);
                inserted = true;
              } else if( !inserted 
                         && sortedDiagramElement.element is 
                            UML.Classes.Kernel.Classifier
                         && diagramElement.element is 
                            UML.Classes.Kernel.Classifier )
              {
                // check if the diagramelement.element is in the targets of
                // the directed relationships of the sorted element
                foreach (UML.Classes.Kernel.DirectedRelationship relation in 
        sortedDiagramElement.element.getRelationships<UML.Classes.Kernel.DirectedRelationship>())
                {
                  if( diagramElement.element.Equals(relation.target) ) {
                    sortedDiagramElements.Insert(i,diagramElement);
                    inserted = true;
                  }
                }
              }
              if( i == sortedDiagramElements.Count -1 ) {
                //if we reached the end then just add the element to the end
                sortedDiagramElements.Add(diagramElement);
                inserted = true;
              }
            }                       
          }
        }
      }
      return sortedDiagramElements;
    }

    public UML.Diagrams.DiagramElement cloneDiagramElement
        (UML.Diagrams.Diagram ownerDiagram, 
         UML.Diagrams.DiagramElement diagramElement,
         Dictionary<UML.Classes.Kernel.Element, UML.Classes.Kernel.Element>
           clonedElementsMap)
    {
      // clone the element itself
      UML.Classes.Kernel.Element clonedElement = 
        this.cloneElement( ownerDiagram.owner, diagramElement.element,
                           clonedElementsMap, false );
      // create the new DiagramElement
      UML.Diagrams.DiagramElement clonedDiagramElement = 
        this.createNewDiagramElement(ownerDiagram, clonedElement);

      if (clonedDiagramElement != null) {
        // copy the attributes
        clonedDiagramElement.xPosition = diagramElement.xPosition;
        clonedDiagramElement.yPosition = diagramElement.yPosition;
      }
      return clonedDiagramElement;
    }

    /// clone the given element as an owned element of the given owner
    public UML.Classes.Kernel.Element cloneElement
      ( UML.Classes.Kernel.Element owner, 
        UML.Classes.Kernel.Element element,
        Dictionary<UML.Classes.Kernel.Element, UML.Classes.Kernel.Element> 
        clonedElementsMap, 
        bool deep )
    {
      UML.Classes.Kernel.Element clonedElement = null;
      // check if the element is already cloned
      if( clonedElementsMap.TryGetValue(element, out clonedElement) ) {
        // do nothing, clonedElement is now filled in.
      } else if (element is UML.Classes.Kernel.Class) {
        UML.Classes.Kernel.Class sourceClass = 
          (UML.Classes.Kernel.Class)element;
        UML.Classes.Kernel.Class clonedClass = 
          this.createNewElement<UML.Classes.Kernel.Class>
            (owner,((UML.Classes.Kernel.Class)element).name);
        // copy (meta)attributes
        clonedClass.isAbstract = sourceClass.isAbstract;
        clonedElement = clonedClass;
      } else if (element is UML.Profiles.Stereotype) {
        clonedElement = 
          this.createNewElement<UML.Profiles.Stereotype>
            (owner,((UML.Profiles.Stereotype)element).name);
      } else if (element is UML.Classes.Interfaces.Interface) {
        clonedElement = 
          this.createNewElement<UML.Classes.Interfaces.Interface>
            (owner, ((UML.Classes.Interfaces.Interface)element).name);
      } else if (element is UML.Classes.Kernel.Operation) {
        UML.Classes.Kernel.Operation sourceOperation = 
          (UML.Classes.Kernel.Operation)element;
        UML.Classes.Kernel.Operation clonedOperation = 
          this.createNewElement<UML.Classes.Kernel.Operation>
            (owner, ((UML.Classes.Kernel.Operation)element).name);
        clonedOperation.visibility = sourceOperation.visibility;
        clonedOperation.isAbstract = sourceOperation.isAbstract;
        clonedOperation.isStatic   = sourceOperation.isStatic;
        clonedElement = clonedOperation;
      } else if (element is UML.Classes.Kernel.Parameter) {
        UML.Classes.Kernel.Parameter sourceParameter = 
          (UML.Classes.Kernel.Parameter)element;
        UML.Classes.Kernel.Parameter clonedParameter = 
          this.createNewElement<UML.Classes.Kernel.Parameter>
            (owner, sourceParameter.name);
        // if the type of the parameter is already cloned we take that.
        // otherwise we create a new primitive type
        UML.Classes.Kernel.Element clonedParameterType;
        if (clonedElementsMap.TryGetValue(sourceParameter.type, out
                                          clonedParameterType))
        {
          clonedParameter.type = 
            clonedParameterType as UML.Classes.Kernel.Type;
        } else {
          clonedParameter.type = 
            this.createPrimitiveType(sourceParameter.type.name);
        }
        // set the direction
        clonedParameter.direction = sourceParameter.direction;
        clonedElement = clonedParameter;
      } else if (element is UML.Classes.Kernel.Generalization) {
        UML.Classes.Kernel.Generalization clonedGeneralization = 
          this.createNewElement<UML.Classes.Kernel.Generalization>
            (owner, string.Empty);
        // clone source
        clonedGeneralization.source = 
          this.cloneElement
            (owner, ((UML.Classes.Kernel.Generalization)element).source, 
            clonedElementsMap,false);
        // clone target
        clonedGeneralization.target = 
          this.cloneElement
            (owner, ((UML.Classes.Kernel.Generalization)element).target, 
            clonedElementsMap,false); 
        clonedElement = clonedGeneralization; 
      } else if (element is UML.Classes.Interfaces.InterfaceRealization) {
        UML.Classes.Interfaces.InterfaceRealization 
          clonedInterfaceRealization = 
            this.createNewElement<UML.Classes.Interfaces.InterfaceRealization>
              (owner, 
                ((UML.Classes.Interfaces.InterfaceRealization)element).name);
        // clone source
        clonedInterfaceRealization.source = 
          this.cloneElement
            (owner, 
             ((UML.Classes.Interfaces.InterfaceRealization)element).source, 
             clonedElementsMap,false);
        // clone target
        clonedInterfaceRealization.target = 
          this.cloneElement
            (owner, 
             ((UML.Classes.Interfaces.InterfaceRealization)element).target, 
             clonedElementsMap,false);
          clonedElement = clonedInterfaceRealization; 
      } else if (element is UML.Classes.Dependencies.Dependency) {
        UML.Classes.Dependencies.Dependency sourceDependency = 
          element as UML.Classes.Dependencies.Dependency;
        UML.Classes.Dependencies.Dependency clonedDependency = 
          this.createNewElement<UML.Classes.Dependencies.Dependency>
            (owner, sourceDependency.name);
        // clone client and supplier
        clonedDependency.client = 
          this.cloneElement(owner, sourceDependency.client, clonedElementsMap, 
                            false) as UML.Classes.Kernel.NamedElement;
        clonedDependency.supplier = 
          this.cloneElement(owner, sourceDependency.supplier, 
                            clonedElementsMap, false) 
                            as UML.Classes.Kernel.NamedElement;
          clonedElement = clonedDependency;
      } else if (element is UML.Classes.Kernel.Association) {
        clonedElement = 
          this.createNewElement<UML.Classes.Kernel.Association>
            (owner, ((UML.Classes.Kernel.Association)element).name);
      } else if (element is UML.Classes.Kernel.Property) {
        UML.Classes.Kernel.Property sourceProperty = 
          (UML.Classes.Kernel.Property)element;
        UML.Classes.Kernel.Property clonedProperty = 
          this.createNewElement<UML.Classes.Kernel.Property>
            (owner, sourceProperty.name);
        UML.Classes.Kernel.Element clonedPropertyType;
        if (clonedElementsMap.TryGetValue( sourceProperty.type,out 
                                           clonedPropertyType))
        {
          clonedProperty.type = clonedPropertyType 
            as UML.Classes.Kernel.Type;
        } else {
          clonedProperty.type = 
            this.cloneElement(clonedProperty, sourceProperty.type, 
                              clonedElementsMap, false) 
              as UML.Classes.Kernel.Type;
        }
        clonedProperty.aggregation  = sourceProperty.aggregation;
        clonedProperty.isNavigable = sourceProperty.isNavigable;
        clonedProperty.visibility   = sourceProperty.visibility;
        clonedProperty.isStatic     = sourceProperty.isStatic;
        clonedElement               = clonedProperty;
      } else if (element is UML.Classes.Kernel.PrimitiveType) {
        clonedElement = 
          this.createPrimitiveType
            (((UML.Classes.Kernel.PrimitiveType)element).name);
      } else if (element is UML.Classes.Kernel.Comment) {
        UML.Classes.Kernel.Comment sourceComment = 
          (UML.Classes.Kernel.Comment)element;
        // comments do not have a name
        UML.Classes.Kernel.Comment clonedComment = 
          this.createNewElement<UML.Classes.Kernel.Comment>
            (owner, string.Empty);
        // clone body
        clonedComment.body = sourceComment.body;
        //clone annotated elements
        foreach(UML.Classes.Kernel.Element annotatedElement in 
                sourceComment.annotatedElements) 
        {
          HashSet<UML.Classes.Kernel.Element> clonedAnnotatedElements = 
            new HashSet<UML.Classes.Kernel.Element>();
          clonedAnnotatedElements.Add( 
            this.cloneElement( owner, annotatedElement, 
                               clonedElementsMap, false));
          clonedComment.annotatedElements = clonedAnnotatedElements;
        }
        clonedElement = clonedComment;
      }
      
      // copy stereotypes
      if( clonedElement != null ) {
        foreach( UML.Profiles.Stereotype stereotype in element.stereotypes) {
          clonedElement.addStereotype(this.createStereotype(clonedElement, 
                                                            stereotype.name));
        }
      }
      if( deep ) {
        foreach (UML.Classes.Kernel.Element ownedElement in
                 element.ownedElements) 
        {
          this.cloneElement(clonedElement, ownedElement, clonedElementsMap,
                            true);
        }
      }
      return clonedElement;
    }

    public abstract UML.Diagrams.DiagramElement createNewDiagramElement
        (UML.Diagrams.Diagram owner, UML.Classes.Kernel.Element element);
  	
	public virtual ICollection<UML.Profiles.TaggedValue> createTaggedValues(IEnumerable taggedValuesToWrap)
	{
		List<UML.Profiles.TaggedValue> taggedValues = new List<UML.Profiles.TaggedValue>();
		foreach (object tagToWrap in taggedValuesToWrap) 
		{
			UML.Profiles.TaggedValue taggedValue = this.createTaggedValue(tagToWrap);
			if (taggedValue != null)
			{
				taggedValues.Add(taggedValue);
			}
		}
		return taggedValues;
	}
	
	public abstract UML.Profiles.TaggedValue createTaggedValue (object objectToWrap);
  }
}
