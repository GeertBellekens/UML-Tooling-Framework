using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.BasicBehaviors {

    //A behavior with implementation-specific semantics.
	public interface OpaqueBehavior : Behavior {

        //Specifies the behavior in one or more languages.
		 HashSet<string> bodies{ get; set; }

        //Languages the body strings use in the same order as the body strings.
         HashSet<string> languages{ get; set; }
	}
}