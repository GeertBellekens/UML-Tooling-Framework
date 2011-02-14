using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {

    //An action is a named element that is the fundamental unit of executable functionality. The execution of an action
    //represents some transformation or processing in the modeled system, be it a computer system or otherwise.
	public interface  Action : UML.Classes.Kernel.NamedElement {
        
        //The classifier that owns the behavior of which this action is a part.
		 UML.Classes.Kernel.Classifier context{ get; set; }
        
        //The ordered set of input pins connected to the Action. These are among the total set of inputs. {Specializes
        //Element::ownedElement}
         HashSet<InputPin> input{ get; set; }

        //The ordered set of output pins connected to the Action. The action places its results onto pins in this set.
        //{Specializes Element::ownedElement}
		 HashSet<OutputPin> output{ get; set; }
		
	}
}