using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {
    
    //CallBehaviorAction is a call action that invokes a behavior directly rather than invoking a behavioral feature that, in turn,
    //results in the invocation of that behavior. The argument values of the action are available to the execution of the invoked
    //behavior. For synchronous calls the execution of the call behavior action waits until the execution of the invoked behavior
    //completes and a result is returned on its output pin. The action completes immediately without a result, if the call is
    //asynchronous.
    public interface CallBehaviorAction : CallAction {

        //The invoked behavior. It must be capable of accepting and returning control.
        UML.CommonBehaviors.BasicBehaviors.Behavior behavior { get; set; }

	}

}