using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {
	
    //Specifies the occurrence of events, such as sending and receiving of signals or invoking or receiving of operation calls. A
    //message occurrence specification is a kind of message end. Messages are generated either by synchronous operation calls
    //or asynchronous signal sends. They are received by the execution of corresponding accept event actions.    
    public interface MessageOccurrenceSpecification : OccurrenceSpecification, MessageEnd {

        //The event associated with the message occurrence.
		new UML.CommonBehaviors.Communications.MessageEvent event_{ get; set; }

	}
}