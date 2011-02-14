using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {
	
    //A Continuation is a syntactic way to define continuations of different branches of an Alternative CombinedFragment.
    //Continuation is intuitively similar to labels representing intermediate points in a flow of control.
    public interface Continuation : InteractionFragment {

        //True when the Continuation is at the end of the enclosing InteractionFragment and False when it is in the beginning.
		bool setting{ get; set; }
	}
}