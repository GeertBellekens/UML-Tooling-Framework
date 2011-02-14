using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {
	
    //An InteractionConstraint is a Boolean expression that guards an operand in a CombinedFragment.
    //InteractionConstraint is a specialization of Constraint.
    //Furthermore the InteractionConstraint contains two expressions designating the minimum and maximum number of times
    //a loop CombinedFragment should execute.
    public interface InteractionConstraint : UML.Classes.Kernel.Constraint {

        //The minimum number of iterations of a loop.
        UML.Classes.Kernel.ValueSpecification minint{ get; set; }

        //The maximum number of iterations of a loop.
        UML.Classes.Kernel.ValueSpecification maxint{ get; set; }
	}
}