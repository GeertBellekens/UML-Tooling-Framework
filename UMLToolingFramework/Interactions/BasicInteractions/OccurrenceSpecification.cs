using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {
	
    //An OccurrenceSpecification is the basic semantic unit of Interactions. The sequences of occurrences specified by them
    //are the meanings of Interactions.
    //OccurrenceSpecifications are ordered along a Lifeline.
    //The namespace of an OccurrenceSpecification is the Interaction in which it is contained.    
    public interface  OccurrenceSpecification : InteractionFragment {

        //References a specification of the occurring event.
        UML.CommonBehaviors.Communications.Event event_{ get; set; }

        //References the Lifeline on which the OccurrenceSpecification appears. Redefines InteractionFragment.covered.
        new Lifeline covered{ get; set; }

        //References the GeneralOrderings that specify EventOcurrences that must occur before this OccurrenceSpecification.
		HashSet<GeneralOrdering> toBefores{ get; set; }

        //References the GeneralOrderings that specify EventOcurrences that must occur after this OccurrenceSpecification.
        HashSet<GeneralOrdering> toAfters{ get; set; }
	}
}