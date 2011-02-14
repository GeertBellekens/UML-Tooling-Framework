using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.BasicInteractions {

    //A MessageEnd is an abstract NamedElement that represents what can occur at the end of a Message.
    public interface  MessageEnd : UML.Classes.Kernel.NamedElement {

        //References a Message.  
		Message message{ get; set; }
	}
}