using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {
    //An action with implementation-specific semantics.
    public interface OpaqueAction : Action {
        
        //Specifies the action in one or more languages.
        HashSet<string> bodies { get; set; }

        //Languages the body strings use in the same order as the body strings.
        HashSet<string> languages { get; set; }

        //Provides input to the action. (Specializes Action::input)
        HashSet<InputPin> inputValue { get; set; }

        //Takes output from the action. (Specializes Action::output)
        HashSet<OutputPin> outputValue { get; set; }
	}
}