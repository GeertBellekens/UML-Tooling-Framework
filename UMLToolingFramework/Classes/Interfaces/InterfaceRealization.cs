using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Interfaces {
  /// An InterfaceRealization is a specialized Realization relationship 
  /// between a Classifier and an Interface. This relationship signifies that
  /// the realizing classifier conforms to the contract specified by the 
  /// Interface.
	public interface InterfaceRealization : 
	  UML.Classes.Dependencies.Realization 
	{
    Interface contract { get; set; }
    BehavioredClassifier implementingClassifier { get; set; }
	}
}
