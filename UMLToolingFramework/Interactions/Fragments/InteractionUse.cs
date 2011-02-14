using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {

    //An InteractionUse refers to an Interaction. The InteractionUse is a shorthand for copying the contents of the referred
    //Interaction where the InteractionUse is. To be accurate the copying must take into account substituting parameters with
    //arguments and connect the formal gates with the actual ones.
    //It is common to want to share portions of an interaction between several other interactions. An InteractionUse allows
    //multiple interactions to reference an interaction that represents a common portion of their specification.
	public interface InteractionUse : InteractionFragment {

        //Refers to the Interaction that defines its meaning.
		Interaction refersTo {get; set;}

        //The actual arguments of the Interaction.
        HashSet<UML.Actions.BasicActions.Action> arguments {get; set;}

        //The actual gates of the InteractionUse.
        HashSet<Gate> actualGates {get; set;}

	}

}