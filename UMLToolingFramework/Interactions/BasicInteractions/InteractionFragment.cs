using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //InteractionFragment is an abstract notion of the most general interaction unit. An interaction fragment is a piece of an
    //interaction. Each interaction fragment is conceptually like an interaction by itself. InteractionFragment is an abstract class
    //and a specialization of NamedElement.
	public interface  InteractionFragment : UML.Classes.Kernel.NamedElement {

        //The operand enclosing this InteractionFragment (they may nest recursively).
        UML.Interactions.Fragments.InteractionOperand enclosingOperand { get; set; }

        //References the Lifelines that the InteractionFragment involves.
        HashSet<Lifeline> covered{ get; set; }

        //The general ordering relationships contained in this fragment.
		HashSet<GeneralOrdering> generalOrderings{ get; set; }

        //The Interaction enclosing this InteractionFragment.
        HashSet<Interaction> enclosingInteraction { get; set; }
	}

}