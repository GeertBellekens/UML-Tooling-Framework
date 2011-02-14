using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {
	
    //ActionExecutionSpecification is a kind of ExecutionSpecification representing the execution of an action.
    public interface ActionExecutionSpecification : ExecutionSpecification {

        //Action whose execution is occurring.
		UML.Actions.BasicActions.Action action{ get; set; }
	}

}