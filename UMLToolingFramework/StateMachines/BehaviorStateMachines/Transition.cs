using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// A transition is a directed relationship between a source vertex and a target vertex. It may be part of a compound
	/// transition, which takes the state machine from one state configuration to another, representing the complete response of
	/// the state machine to an occurrence of an event of a particular type.
	/// </summary>
	public interface Transition : UML.Classes.Kernel.NamedElement, UML.Classes.Kernel.RedefinableElement 
	{
		/// <summary>
		/// See definition of TransitionKind. Default value is external.
		/// </summary>
		TransitionKind kind {get;set;}	
		
		/// <summary>
		/// Specifies the triggers that may fire the transition.
		/// </summary>
		HashSet<UML.CommonBehaviors.Communications.Trigger> triggers {get;set;}
		
		/// <summary>
		/// A guard is a constraint that provides a fine-grained control over the firing of the transition. The guard is evaluated
		/// when an event occurrence is dispatched by the state machine. If the guard is true at that time, the transition may be
		/// enabled; otherwise, it is disabled. Guards should be pure expressions without side effects. Guard expressions with
		/// side effects are ill-formed. {Subsets Namespace::ownedRule}
		/// </summary>
		UML.Classes.Kernel.Constraint guard {get;set;}
		
		/// <summary>
		/// Specifies an optional behavior to be performed when the transition fires.
		/// </summary>
		UML.CommonBehaviors.BasicBehaviors.Behavior effect {get;set;}

		/// <summary>
		/// Specifies the Operation linked as Effect. (Non standard UML)
		/// </summary>
		UML.Classes.Kernel.Operation effectOperation { get; set; }

		/// <summary>
		/// Designates the originating vertex (state or pseudostate) of the transition.
		/// </summary>
		Vertex source {get;set;}
		
		/// <summary>
		/// Designates the target vertex that is reached when the transition is taken.
		/// </summary>
		Vertex target {get;set;}
		
		/// <summary>
		/// The transition of which this is a replacement. {Subsets RedefinableElement::redefinedElement}
		/// </summary>
		Transition redefinedTransition {get;set;}
		
		/// <summary>
		/// References the classifier in which context this element may be redefined. {Redefines
		/// RedefinableElement::redefinitionContext}
		/// </summary>
		UML.Classes.Kernel.Classifier redefinitionContext {get;set;}
		
		/// <summary>
		/// Designates the region that owns this transition. (Subsets Namespace.namespace)
		/// </summary>
		Region container {get;set;}
		
	}

}