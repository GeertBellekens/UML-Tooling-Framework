using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //A SendSignalEvent models the sending of a signal.
    public interface SendSignalEvent : UML.CommonBehaviors.Communications.MessageEvent {

        //The signal associated with this event.
        UML.CommonBehaviors.Communications.Signal signal{ get; set; }
	}
}