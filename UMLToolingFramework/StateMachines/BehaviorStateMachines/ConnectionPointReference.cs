using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// Connection point references of a submachine state can be used as sources/targets of transitions. They represent entries
	/// into or exits out of the submachine state machine referenced by the submachine state.
	/// </summary>
	public interface ConnectionPointReference : Vertex
	{
		/// <summary>
		/// The entryPoint kind pseudostates corresponding to this connection point.
		/// </summary>
		HashSet<Pseudostate> entries {get;set;}
		
		/// <summary>
		/// The exitPoints kind pseudostates corresponding to this connection point.
		/// </summary>
		HashSet<Pseudostate> exits {get;set;}
		
		/// <summary>
		/// The State in which the connection point references are defined. {Subsets Element::namespace}
		/// </summary>
		State state {get;set;}

	}

}