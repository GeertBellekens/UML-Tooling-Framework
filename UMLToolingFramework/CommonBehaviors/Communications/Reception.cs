using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {
	
    //A reception is a declaration stating that a classifier is prepared to react to the receipt of a signal. A reception designates a
    //signal and specifies the expected behavioral response. The details of handling a signal are specified by the behavior
    //associated with the reception or the classifier itself.
    public interface Reception : UML.Classes.Kernel.BehavioralFeature {

        //The signal that this reception handles.
		Signal signal{ get; set; }

	}

}