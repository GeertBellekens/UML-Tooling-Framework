using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //A GeneralOrdering represents a binary relation between two OccurrenceSpecifications, to describe that one
    //OccurrenceSpecification must occur before the other in a valid trace. This mechanism provides the ability to define partial
    //orders of OccurrenceSpecifications that may otherwise not have a specified order.
    //A GeneralOrdering is a specialization of NamedElement.
    //A GeneralOrdering may appear anywhere in an Interaction, but only between OccurrenceSpecifications.
    public interface GeneralOrdering : UML.Classes.Kernel.NamedElement {

        //The OccurrenceSpecification referenced comes before the OccurrenceSpecification referenced by after.
        OccurrenceSpecification before{ get; set; }

        //The OccurrenceSpecification referenced comes after the OccurrenceSpecification referenced by before.
		OccurrenceSpecification after{ get; set; }

	}
}