using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// State machines can be used to express the behavior of part of a system. Behavior is modeled as a traversal of a graph of
	/// state nodes interconnected by one or more joined transition arcs that are triggered by the dispatching of series of (event)
	/// occurrences. During this traversal, the state machine executes a series of activities associated with various elements of the
	/// state machine.
	/// 
	/// A state machine owns one or more regions, which in turn own vertices and transitions.
	/// The behaviored classifier context owning a state machine defines which signal and call triggers are defined for the state
	/// machine, and which attributes and operations are available in activities of the state machine. Signal triggers and call
	/// triggers for the state machine are defined according to the receptions and operations of this classifier.
	/// As a kind of behavior, a state machine may have an associated behavioral feature (specification) and be the method of this
	/// behavioral feature. In this case the state machine specifies the behavior of this behavioral feature. The parameters of the
	/// state machine in this case match the parameters of the behavioral feature and provide the means for accessing (within the
	/// state machine) the behavioral feature parameters.
	/// A state machine without a context classifier may use triggers that are independent of receptions or operations of a
	/// classifier, i.e., either just signal triggers or call triggers based upon operation template parameters of the (parameterized)
	/// statemachine.
	/// </summary>
	public interface StateMachine : UML.CommonBehaviors.BasicBehaviors.Behavior 
	{
		
		/// <summary>
		/// The regions owned directly by the state machine.
		/// </summary>
		HashSet<Region> regions {get;set;}
		
		/// <summary>
		/// The connection points defined for this state machine. They represent the interface of the state machine when used as
		/// part of submachine state.
		/// </summary>
		HashSet<Pseudostate> connectionPoints {get;set;}
				
		/// <summary>
		/// The state machines of which this is an extension. {Subsets RedefineableElement::redefinedElement}
		/// </summary>
		HashSet<StateMachine> extendedStateMachines {get;set;}
		
	}

}