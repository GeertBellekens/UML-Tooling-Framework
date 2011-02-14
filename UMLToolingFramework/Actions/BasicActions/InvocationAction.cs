using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {

    //Invocation is an abstract class for the various actions that invoke behavior.
    public interface  InvocationAction : Action {
        
        //Specification of the ordered set of argument values that appear during execution.
		HashSet<InputPin> arguments{ get; set; }
	}
}