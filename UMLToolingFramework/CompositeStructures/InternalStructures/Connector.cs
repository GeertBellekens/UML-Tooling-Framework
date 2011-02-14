using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CompositeStructures.InternalStructures {

    //Each connector may be attached to two or more connectable elements, each representing a set of instances. Each
    //connector end is distinct in the sense that it plays a distinct role in the communication realized over a connector. The
    //communications realized over a connector may be constrained by various constraints (including type constraints) that
    //apply to the attached connectable elements.
    public interface Connector : UML.Classes.Kernel.Feature {

        //A connector consists of at least two connector ends, each representing the participation of instances of the classifiers
        //typing the connectable elements attached to this end. The set of connector ends is ordered.
        //(SubsetsElement::ownedElement)
		HashSet<ConnectorEnd> ends {get; set;}

        //An optional association that specifies the link corresponding to this connector.
        UML.Classes.Kernel.Association type { get; set; }

        //A connector may be redefined when its containing classifier is specialized. The redefining connector may have a type
        //that specializes the type of the redefined connector. The types of the connector ends of the redefining connector may
        //specialize the types of the connector ends of the redefined connector. The properties of the connector ends of the
        //redefining connector may be replaced. (Subsets Element::redefinedElement)
		HashSet<Connector> redefinedConnector {get; set;}
	}
}