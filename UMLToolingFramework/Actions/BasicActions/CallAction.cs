using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {

    //CallAction is an abstract class for actions that invoke behavior and receive return values.    
    public interface  CallAction : InvocationAction {

        //If true, the call is synchronous and the caller waits for completion of the invoked behavior. If false, the call is
        //asynchronous and the caller proceeds immediately and does not expect a return value.
		 bool isSynchronous { get; set; }

        //A list of output pins where the results of performing the invocation are placed. {Subsets Action::input}
		 HashSet<OutputPin> result{ get; set; }

	}
}