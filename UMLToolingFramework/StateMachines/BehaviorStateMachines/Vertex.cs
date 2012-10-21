using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{

	/// <summary>
	/// A vertex is an abstraction of a node in a state machine graph. In general, it can be the source or destination of any number
	/// of transitions.
	/// </summary>
	public interface  Vertex : UML.Classes.Kernel.NamedElement
	{

		/// <summary>
		/// Specifies the transitions departing from this vertex. Derived in the following way:
		/// context Vertex::outgoing derive:
		/// Transition.allInstances() -> select(t | t.source = self)
		/// </summary>
		HashSet<Transition> outgoings {get;set;}
		
		/// <summary>
		/// Specifies the transitions entering this vertex. Derived in the following way:
		/// context Vertex::incoming derive:
		/// Transition.allInstances() -> select(t | t.target = self)
		/// </summary>
		HashSet<Transition> incomings {get;set;}
		
		/// <summary>
		/// The region that contains this vertex. {Subsets Element::owner}
		/// </summary>
		Region container {get;set;}
		

	}

}