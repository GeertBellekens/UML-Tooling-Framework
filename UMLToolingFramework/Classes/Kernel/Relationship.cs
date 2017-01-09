using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Relationship : Element {
    List<Element> relatedElements { get; set; }
    /// <summary>
    /// adds a related element to the relationship
    /// </summary>
    /// <param name="relatedElement">the element to add</param>
    void addRelatedElement(Element relatedElement);
    /// <summary>
    /// saves the changes to the relationship
    /// </summary>
    void save();
    /// <summary>
    /// convenience method to return the information flows that realize this Relationship
    /// </summary>
    /// <returns>the information flows that realize this Relationship</returns>
    HashSet<UML.InfomationFlows.InformationFlow> getInformationFlows();
    /// <summary>
    /// returns a list of elements that are linked to this relationship (but not the related elements)
    /// these are the notes or constrains linked to the relation, or the elments linked to this relation through another relation
    /// </summary>
    List<Element> getLinkedElements();
	}
}