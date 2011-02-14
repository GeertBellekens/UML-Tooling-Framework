using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {

    //A combined fragment defines an expression of interaction fragments. A combined fragment is defined by an interaction
    //operator and corresponding interaction operands. Through the use of CombinedFragments the user will be able to describe
    //a number of traces in a compact and concise manner.
    //CombinedFragment is a specialization of InteractionFragment.
	public interface CombinedFragment : InteractionFragment {

        //Specifies the operation that defines the semantics of this combination of InteractionFragments. Default value is seq.
		InteractionOperatorKind interactionOperator{ get; set; }

        //Specifies the gates that form the interface between this CombinedFragment and its surroundings.
        Gate cfragmentGate{ get; set; }

        //The set of operands of the combined fragment. {Subsets Element::ownedElement}
		HashSet<InteractionOperand> operands{ get; set; }
	}
}