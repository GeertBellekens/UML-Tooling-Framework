using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //BehaviorExecutionSpecification is a kind of ExecutionSpecification representing the execution of a behavior.
    public interface BehaviorExecutionSpecification : ExecutionSpecification {

        //Behavior whose execution is occurring.
		UML.CommonBehaviors.BasicBehaviors.Behavior behavior{ get; set; }
	}
}