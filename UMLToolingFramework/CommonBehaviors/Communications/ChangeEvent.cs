using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {
	
    //A change event occurs when a Boolean-valued expression becomes true. For example, as a result of a change in the value
    //held in a slot corresponding to an attribute, or a change in the value referenced by a link corresponding to an association.
    //A change event is raised implicitly and is not the result of an explicit action.
    public interface ChangeEvent : Event {

        //A Boolean-valued expression that will result in a change event whenever its value changes from false to true.
        //{Subsets Element::ownedElement}		
        UML.Classes.Kernel.Expression changeExpression{ get; set; }

	}

}