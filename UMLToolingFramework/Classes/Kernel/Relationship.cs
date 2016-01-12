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
	}
}
