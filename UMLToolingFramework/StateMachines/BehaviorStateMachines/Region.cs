using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// A region is an orthogonal part of either a composite state or a state machine. It contains states and transitions.
	/// </summary>
	public interface Region : UML.Classes.Kernel.Namespace, UML.Classes.Kernel.RedefinableElement 
	{
		/// <summary>
		/// The StateMachine that owns the Region. If a Region is owned by a StateMachine, then it cannot also be owned by a
		/// State. {Subsets NamedElement::namespace}
		/// </summary>
		StateMachine stateMachine {get;set;}
		
		/// <summary>
		/// The State that owns the Region. If a Region is owned by a State, then it cannot also be owned by a StateMachine.
		/// {Subsets NamedElement::namespace}
		/// </summary>
		State state {get;set;}
		
		/// <summary>
		/// The set of transitions owned by the region. {Subsets Namespace::ownedMember}
		/// </summary>
		HashSet<Transition> transitions {get;set;}
		
		/// <summary>
		/// The set of vertices that are owned by this region. {Subsets Namespace::ownedMember}
		/// </summary>
		HashSet<Vertex> subvertices {get;set;}
		
		/// <summary>
		/// The region of which this region is an extension. {Subsets RedefinableElement::redefinedElement}
		/// </summary>
		Region extendedRegion {get;set;}
		
		/// <summary>
		/// References the classifier in which context this element may be redefined. {Redefines
		/// RedefinableElement::redefinitionContext}
		/// </summary>
		UML.Classes.Kernel.Classifier redefinitionContext {get;set;}

	}

}