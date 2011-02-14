using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Association : Classifier, Relationship {
    bool isDerived { get; set; }
    List<Property> navigableOwnedEnds { get; set; }
    List<Property> ownedEnds { get; set; }
    List<Type> endTypes { get; set; }
    /// Each end represents participation of instances of the classifier
    /// connected to the end in links of the association. This is an ordered
    // association. Subsets Namespace::member.
    List<Property> memberEnds { get; set; }
	}
}
