using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {

    //A Gate is a connection point for relating a Message outside an InteractionFragment with a Message inside the
    //InteractionFragment.
    //Gate is a specialization of MessageEnd.
    //Gates are connected through Messages. A Gate is actually a representative of an OccurrenceSpecification that is not in the
    //same scope as the Gate.
    //Gates play different roles: we have formal gates on Interactions, actual gates on InteractionUses, expression gates on
    //CombinedFragments.
	public interface Gate : UML.Interactions.BasicInteractions.MessageEnd {
	}
}