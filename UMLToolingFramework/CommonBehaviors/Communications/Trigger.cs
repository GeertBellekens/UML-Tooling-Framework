using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {

    //A trigger specifies an event that may cause the execution of an associated behavior. An event is often ultimately caused
    //by the execution of an action, but need not be.    
    public interface Trigger : UML.Classes.Kernel.NamedElement {

        //The event that causes the trigger.
		Event event_{ get; set; }

	}
}