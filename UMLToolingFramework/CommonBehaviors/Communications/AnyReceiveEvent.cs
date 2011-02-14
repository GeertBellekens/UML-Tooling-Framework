using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {
	
    //A trigger for an AnyReceiveEvent is triggered by the receipt of any message that is not explicitly handled by any related
    //trigger.
    public interface AnyReceiveEvent : MessageEvent {

	}
}