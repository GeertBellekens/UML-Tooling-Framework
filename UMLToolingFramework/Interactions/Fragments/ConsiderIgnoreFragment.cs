using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {

    //A ConsiderIgnoreFragment is a kind of combined fragment that is used for the consider and ignore cases, which require
    //lists of pertinent messages to be specified.
    public interface ConsiderIgnoreFragment : CombinedFragment {

        //The set of messages that apply to this fragment.
		HashSet<UML.Classes.Kernel.NamedElement> messages{ get; set; }
	}
}