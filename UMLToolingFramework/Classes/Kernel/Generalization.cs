namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Generalization : DirectedRelationship {
    bool isSubstitutable { get; set; }
    Classifier general   { get; set; }
    Classifier specific  { get; set; }
	}
}
