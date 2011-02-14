using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Dependencies {
	public interface Substitution : Realization {
    UML.Classes.Kernel.Classifier contract { get; set; }
    UML.Classes.Kernel.Classifier substitutingClassifier { get; set; }
	}
}
