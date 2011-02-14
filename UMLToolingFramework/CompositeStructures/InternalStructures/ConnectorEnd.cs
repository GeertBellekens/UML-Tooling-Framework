using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CompositeStructures.InternalStructures {
	
    //A connector end is an endpoint of a connector, which attaches the connector to a connectable element. Each connector
    //end is part of one connector.
    public interface ConnectorEnd : UML.Classes.Kernel.MultiplicityElement {

        //The connectable element attached at this connector end. When an instance of the containing classifier is created, a
        //link may (depending on the multiplicities) be created to an instance of the classifier that types this connectable
        //element.
        ConnectableElement role { get; set; }

        //A derived association referencing the corresponding association end on the association that types the connector
        //owing this connector end. This association is derived by selecting the association end at the same place in the
        //ordering of association ends as this connector end.
		Property definingEnd {get; set;}
		
	}
}