using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //This is an enumerated type that identifies the type of message.
    public enum MessageKind : int {

        //sendEvent and receiveEvent are present.
		complete,

        //sendEvent and receiveEvent are present.    
		lost,

        //sendEvent absent and receiveEvent present.
		found,

        //sendEvent and receiveEvent absent (should not appear).
		unknown
	}
}