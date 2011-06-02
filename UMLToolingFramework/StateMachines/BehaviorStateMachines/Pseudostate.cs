using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// A pseudostate is an abstraction that encompasses different types of transient vertices in the state machine graph.
	/// Pseudostates are typically used to connect multiple transitions into more complex state transitions paths. For example, by
	/// combining a transition entering a fork pseudostate with a set of transitions exiting the fork pseudostate, we get a
	/// compound transition that leads to a set of orthogonal target states.
	/// </summary>
	public interface Pseudostate : Vertex 
	{
		/// <summary>
		/// Determines the precise type of the Pseudostate. Default value is initial.
		/// </summary>
		PseudostateKind kind {get;set;}
		
		/// <summary>
		/// The StateMachine in which this Pseudostate is defined. This only applies to Pseudostates of the kind entryPoint or
		/// exitPoint. {Subsets NamedElement::namespace}
		/// </summary>
		StateMachine statemachine {get;set;}
		
		/// <summary>
		/// State that owns the Pseudostate. {Subsets Element::owner}
		/// </summary>
		State state {get;set;}


	}

}