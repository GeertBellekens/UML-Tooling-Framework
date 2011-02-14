using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //A SendOperationEvent models the invocation of an operation call.
    public interface SendOperationEvent : UML.CommonBehaviors.Communications.MessageEvent {

        //The operation associated with this event.
		UML.Classes.Kernel.Operation operation{ get; set; }
	}
}