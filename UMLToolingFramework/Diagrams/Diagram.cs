using System.Collections.Generic;

using UML = TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Diagrams {
	public interface Diagram:UMLItem {
        string                           name            { get; set; }
        HashSet<DiagramElement>          diagramElements { get; set; }
        List<UML.Classes.Kernel.Element> elements        { get; set; }
        UML.Classes.Kernel.Element owner {get;set;}
        
        int     height  { get; set; }
        int     width   { get; set; }
        string comment {get;set;}
  		/// <summary>
  		/// The elements that have this diagram as composite diagram
  		/// </summary>
        HashSet<UML.Classes.Kernel.Element> compositeElements {get;}

        /// <summary>
        /// gets the diagramElements for that contain an Element the given type
        /// </summary>
        /// <returns>a set of diagramElement of the given type</returns>
        HashSet<DiagramElement> getDiagramElements<T>() where T:UML.Classes.Kernel.Element;
        /// <summary>
        /// searches downward for the item with the given relative path
        /// This relative path includes the own name
        /// </summary>
        /// <param name="relativePath">list of names inlcuding the own name</param>
        /// <returns>the item matching the path</returns>
        UMLItem getItemFromRelativePath(List<string> relativePath);
        /// <summary>
        /// saves the diagram
        /// </summary>
        void save();
        /// <summary>
        /// select the given item in the diagram
        /// </summary>
        /// <param name="itemToSelect">the item to select</param>
        void selectItem(UMLItem itemToSelect);
        /// <summary>
        /// adds an element to the diagram
        /// </summary>
        /// <param name="element">the element to add</param>
        /// <returns>the new diagramElement</returns>
        DiagramElement addToDiagram(UML.Classes.Kernel.Element element);
        /// <summary>
        /// add the given diagram to this diagram
        /// </summary>
        /// <param name="diagram">the diagram to add</param>
        /// <returns>the new DiagramElement</returns>
        DiagramElement addToDiagram(UML.Diagrams.Diagram diagram);
        
  }
}
