using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {

    //A signal event represents the receipt of an asynchronous signal. A signal event may cause a response, such as a state
    //machine transition as specified in the classifier behavior of the classifier that specified the receiver object, if the signal
    //referenced by the send request is mentioned in a reception owned or inherited by the classifier that specified the receiver
    //object.    
    public interface SignalEvent : MessageEvent {

        //The specific signal that is associated with this event.
		Signal signal{ get; set; }

	}
}