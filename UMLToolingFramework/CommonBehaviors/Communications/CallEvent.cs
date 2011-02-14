using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {

    //A call event represents the reception of a request to invoke a specific operation. A call event is distinct from the call
    //action that caused it. A call event may cause the invocation of a behavior that is the method of the operation referenced
    //by the call request, if that operation is owned or inherited by the classifier that specified the receiver object.	
    public interface CallEvent : MessageEvent {

        //Designates the operation whose invocation raised the call event.
		Operation operation{ get; set; }

	}

}