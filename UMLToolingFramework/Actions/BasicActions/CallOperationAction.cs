using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {
	
    //CallOperationAction is an action that transmits an operation call request to the target object, where it may cause the
    //invocation of associated behavior. The argument values of the action are available to the execution of the invoked
    //behavior. If the action is marked synchronous, the execution of the call operation action waits until the execution of the
    //invoked behavior completes and a reply transmission is returned to the caller; otherwise, execution of the action is
    //complete when the invocation of the operation is established and the execution of the invoked operation proceeds
    //concurrently with the execution of the calling behavior. Any values returned as part of the reply transmission are put on
    //the result output pins of the call operation action. Upon receipt of the reply transmission, execution of the call operation
    //action is complete.
    public interface CallOperationAction : CallAction {

        //The operation to be invoked by the action execution.
        UML.Classes.Kernel.Operation operation { get; set; }

        //The target object to which the request is sent. The classifier of the target object is used to dynamically determine a
        //behavior to invoke. This object constitutes the context of the execution of the operation. {Subsets Action::input}
		InputPin target{ get; set; }

	}
}