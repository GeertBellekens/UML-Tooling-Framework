using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {
	public enum CallConcurrencyKind : int {

        //No concurrency management mechanism is associated with the operation and, therefore, concurrency
        //conflicts may occur. Instances that invoke a behavioral feature need to coordinate so that only one invocation to a target
        //on any behavioral feature occurs at once.
		sequential,

        //Multiple invocations of a behavioral feature may occur simultaneously to one instance, but only one is
        //allowed to commence. The others are blocked until the performance of the currently executing behavioral feature is
        //complete. It is the responsibility of the system designer to ensure that deadlocks do not occur due to simultaneous
        //blocks.
		guarded,

        //Multiple invocations of a behavioral feature may occur simultaneously to one instance and all of them
        //may proceed concurrently.
		concurrent

	}

}