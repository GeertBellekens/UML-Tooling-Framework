using System.Collections.Generic;

using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Interfaces {
  /// For some reason this interface only inherits from NamedElement.
  /// TODO: figure out why this is the case and fix it.
  /// A BehavioredClassifier may have an interface realization.
	public interface  BehavioredClassifier : UML.Classes.Kernel.NamedElement {
    HashSet<InterfaceRealization> interfaceRealizations { get; set; }
	}
}
