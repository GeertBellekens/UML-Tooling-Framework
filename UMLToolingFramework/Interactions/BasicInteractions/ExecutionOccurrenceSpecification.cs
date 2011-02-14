using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //An ExecutionOccurrenceSpecification represents moments in time at which actions or behaviors start or finish.
    public interface ExecutionOccurrenceSpecification : OccurrenceSpecification {

        //Redefines the event referenced to be restricted to an execution event.
        new ExecutionEvent event_{ get; set; }

        //References the execution specification describing the execution that is started or finished at this execution event.
        ExecutionSpecification execution{ get; set; }
		

	}
}