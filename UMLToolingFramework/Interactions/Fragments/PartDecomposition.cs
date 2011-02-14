using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments {
	
    //PartDecomposition is a description of the internal interactions of one Lifeline relative to an Interaction.
    //A Lifeline has a class associated as the type of the ConnectableElement that the Lifeline represents. That class may have
    //an internal structure and the PartDecomposition is an Interaction that describes the behavior of that internal structure
    //relative to the Interaction where the decomposition is referenced.
    //A PartDecomposition is a specialization of InteractionUse. It associates with the ConnectableElement that it decomposes.
	public interface PartDecomposition : InteractionUse {

	}
}