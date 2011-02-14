using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Feature : RedefinableElement {
		bool isStatic { get; set; }
    HashSet<Classifier> featuringClassifiers { get; set; }
	}
}
