using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //An ExecutionSpecification is a specification of the execution of a unit of behavior or action within the Lifeline. The
    //duration of an ExecutionSpecification is represented by two ExecutionOccurrenceSpecifications, the start
    //ExecutionOccurrenceSpecification and the finish ExecutionOccurrenceSpecification.    
    public interface  ExecutionSpecification : InteractionFragment {

        //References the OccurrenceSpecification that designates the start of the Action or Behavior.
        OccurrenceSpecification start{ get; set; }

        //References the OccurrenceSpecification that designates the finish of the Action or Behavior.
		OccurrenceSpecification finish{ get; set; }

	}
}