using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {
	
    //A Message defines a particular communication between Lifelines of an Interaction.
    //A Message is a NamedElement that defines one specific kind of communication in an Interaction. A communication can
    //be, for example, raising a signal, invoking an Operation, creating or destroying an Instance. The Message specifies not
    //only the kind of communication given by the dispatching ExecutionSpecification, but also the sender and the receiver.
    //A Message associates normally two OccurrenceSpecifications - one sending OccurrenceSpecification and one receiving
    //OccurrenceSpecification.
    public interface Message : UML.Classes.Kernel.NamedElement {

        //The derived kind of the Message (complete, lost, found, or unknown). Default value is unknown.
		MessageKind messageKind{ get; set; }

        //The sort of communication reflected by the Message. Default value is synchCall.
        MessageSort messageSort{ get; set; }

        //The enclosing Interaction owning the Message.
        Interaction interaction { get; set; }

        //References the Sending of the Message.
        MessageEnd receiveEvent{ get; set; }

        //References the Receiving of the Message.
		MessageEnd sendEvent{ get; set; }

        //The Connector on which this Message is sent.
		UML.CompositeStructures.InternalStructures.Connector connector{ get; set; }

        //The arguments of the Message.
		HashSet<UML.Classes.Kernel.ValueSpecification> arguments{ get; set; }

        //The definition of the type or signature of the Message (depending on its kind). The associated named element is
        //derived from the message end that constitutes the sending or receiving message event. If both a sending event and
        //a receiving message event are present, the signature is obtained from the sending event.
        UML.Classes.Kernel.NamedElement signature{ get; set; }  
        
        // NOT STANDARD UML
        //convenience operation to get the operation directly from the message.
        //should be derived from this.receiveEvent.event_.operation where the receiveEvent is an occurenceSpecification, and the event is a ReceiveOperationEvent
        UML.Classes.Kernel.Operation calledOperation { get; set; }
	}

}