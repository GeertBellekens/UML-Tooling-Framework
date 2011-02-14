using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {
	
    //A StateInvariant is a runtime constraint on the participants of the interaction. It may be used to specify a variety of
    //different kinds of constraints, such as values of attributes or variables, internal or external states, and so on.
    //A StateInvariant is an InteractionFragment and it is placed on a Lifeline.    
    public interface StateInvariant : InteractionFragment {

        //A Constraint that should hold at runtime for this StateInvariant.
        UML.Classes.Kernel.Constraint invariant { get; set; }

        //References the Lifeline on which the StateInvariant appears. Subsets InteractionFragment.covered.
		new Lifeline covered{ get; set; }
        
	}
}