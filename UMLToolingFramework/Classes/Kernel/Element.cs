using System.Collections.Generic;

using UML = TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Element:UMLItem {
        HashSet<Element> ownedElements { get; set; }
        HashSet<Comment> ownedComments { get; set; }
        Element owner { get; set; }
        HashSet<UML.Profiles.Stereotype> stereotypes { get; set; }
        void addStereotype(UML.Profiles.Stereotype stereotype);
        /// convenience property to get all relationships that are linked to this
        /// Element not defined in UML spec.
        List<Relationship> relationships { get; set; }
        List<T> getRelationships<T>() where T : Relationship;
        HashSet<T> getUsingDiagrams<T>() where T : class,UML.Diagrams.Diagram;
        UMLItem getItemFromRelativePath(List<string> relativePath);
	}
}
