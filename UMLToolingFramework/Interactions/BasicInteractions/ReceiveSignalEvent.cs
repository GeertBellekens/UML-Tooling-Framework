using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //This specifies the event of receiving signal by the target entity
    public interface ReceiveSignalEvent : UML.CommonBehaviors.Communications.MessageEvent {

        //Specifies the signal associated with this event.
        UML.CommonBehaviors.Communications.Signal signal{ get; set; }
	}
}