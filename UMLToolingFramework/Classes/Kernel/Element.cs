using System.Collections.Generic;

using UML = TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Element:UML.Extended.UMLItem {
        HashSet<Element> ownedElements { get; set; }
        HashSet<Comment> ownedComments { get; set; }
        void addStereotype(UML.Profiles.Stereotype stereotype);
        /// convenience property to get all relationships that are linked to this
        /// Element not defined in UML spec.
        List<Relationship> relationships { get; set; }
        List<T> getRelationships<T>() where T : Relationship;
        HashSet<T> getUsingDiagrams<T>() where T : class,UML.Diagrams.Diagram;
        UML.Extended.UMLItem getItemFromRelativePath(List<string> relativePath);
        HashSet<UML.Profiles.TaggedValue> taggedValues{get;set;}
        HashSet<UML.Profiles.TaggedValue> getReferencingTaggedValues();
        UML.Diagrams.Diagram compositeDiagram {get;set;}
       	/// <summary>
	    /// indicates the position of this element in the set of elements owned by the owner
	    /// </summary>
	    int position {get;set;}
	}
}
