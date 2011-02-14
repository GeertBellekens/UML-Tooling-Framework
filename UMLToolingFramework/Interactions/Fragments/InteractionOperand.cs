using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {

    //An InteractionOperand is contained in a CombinedFragment. An InteractionOperand represents one operand of the
    //expression given by the enclosing CombinedFragment.
    //An InteractionOperand is an InteractionFragment with an optional guard expression. An InteractionOperand may be
    //guarded by an InteractionConstraint. Only InteractionOperands with a guard that evaluates to true at this point in the
    //interaction will be considered for the production of the traces for the enclosing CombinedFragment.
    //InteractionOperand contains an ordered set of InteractionFragments.
    //In Sequence Diagrams these InteractionFragments are ordered according to their geometrical position vertically. The
    //geometrical position of the InteractionFragment is given by the topmost vertical coordinate of its contained
    //OccurrenceSpecifications or symbols.
	public interface InteractionOperand : UML.Classes.Kernel.Namespace, InteractionFragment {

        //The fragments of the operand.
		HashSet<InteractionFragment> fragments{ get; set; }

        //Constraint of the operand.
        InteractionConstraint guard{ get; set; }
	}
}