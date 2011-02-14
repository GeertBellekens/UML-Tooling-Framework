using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  RedefinableElement : NamedElement {
		bool                        isLeaf               { get; set; }
		HashSet<RedefinableElement> redefinedElements    { get; set; }
    HashSet<Classifier>         redefinitionContexts { get; set; }
	}
}
