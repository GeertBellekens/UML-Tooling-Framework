using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //This specifies the event of receiving an operation invocation for a particular operation by the target entity.
    public interface ReceiveOperationEvent : UML.CommonBehaviors.Communications.MessageEvent {

        //Specifies the operation associated with this event.
		UML.Classes.Kernel.Operation operation{ get; set; }
	}
}