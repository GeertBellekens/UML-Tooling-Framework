using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {

    //SendSignalAction is an action that creates a signal instance from its inputs, and transmits it to the target object, where it
    //may cause the firing of a state machine transition or the execution of an activity. The argument values are available to the
    //execution of associated behaviors. The requestor continues execution immediately. Any reply message is ignored and is
    //not transmitted to the requestor. If the input is already a signal instance, use SendObjectAction.	
    public interface SendSignalAction : InvocationAction {

        //The type of signal transmitted to the target object.
		UML.CommonBehaviors.Communications.Signal signal{ get; set; }

        //The target object to which the signal is sent. {Subsets Action::input}
        InputPin target{ get; set; }

	}

}