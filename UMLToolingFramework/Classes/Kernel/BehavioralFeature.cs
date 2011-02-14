using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  BehavioralFeature : Feature, Namespace {
    HashSet<Type> raisedExceptions { get; set; }
    HashSet<Parameter> ownedParameters { get; set; }
	}
}
