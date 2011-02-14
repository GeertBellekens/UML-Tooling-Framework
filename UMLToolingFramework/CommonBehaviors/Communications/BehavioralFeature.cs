using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {
	
    //A behavioral feature is implemented (realized) by a behavior. A behavioral feature specifies that a classifier will respond
    //to a designated request by invoking its implementing method.
    public interface  BehavioralFeature : UML.Classes.Kernel.BehavioralFeature  {

        //Specifies the semantics of concurrent calls to the same passive instance (i.e., an instance originating from a class
        //with isActive being false). Active instances control access to their own behavioral features. Default value is
        //sequential.
		CallConcurrencyKind concurrency{ get; set; }
	}
}