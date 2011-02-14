using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CompositeStructures.InternalStructures {
	
    //A ConnectableElement is an abstract metaclass representing a set of instances that play roles of a classifier. Connectable
    //elements may be joined by attached connectors and specify configurations of linked instances to be created within an
    //instance of the containing classifier.
    public interface  ConnectableElement : UML.Classes.Kernel.TypedElement {

        //Denotes a connector that attaches to this connectable element. It is derived in the following way:
        //context ConnectableElement::end derive:
        //ConnectorEnd.allInstances() -> select (e | e.role = self)
		ConnectorEnd end {get; set;}	
	}
}