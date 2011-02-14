using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {
	
    //Interaction OperatorKind is an enumeration designating the different kinds of operators of CombinedFragments. The
    //InteractionOperand defines the type of operator of a CombinedFragment.
    public enum InteractionOperatorKind : int {
		alt,
		opt,
		par,
		loop,
		critical,
		neg,
		assert,
        strict,
        seq,
		ignore,
		consider
	}
}