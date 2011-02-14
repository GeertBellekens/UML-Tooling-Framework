using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //An interaction is a unit of behavior that focuses on the observable exchange of information between
    //ConnectableElements.
    //An Interaction is a specialization of InteractionFragment and of Behavior.
	public interface Interaction : UML.CommonBehaviors.BasicBehaviors.Behavior, InteractionFragment {

        //Specifies the gates that form the message interface between this Interaction and any InteractionUses that reference it.
        HashSet<UML.Interactions.Fragments.Gate> formalGates { get; set; }

        //Specifies the participants in this Interaction.
		HashSet<Lifeline> lifelines{ get; set; }

        //The Messages contained in this Interaction.
		HashSet<Message> messages{ get; set; }

        //The ordered set of fragments in the Interaction.
		HashSet<InteractionFragment> fragments{ get; set; }

        //Actions owned by the Interaction. See “ActionExecutionSpecification (from BasicInteractions)” on page 484.
		HashSet<UML.Actions.BasicActions.Action> actions{ get; set; }

	}
}