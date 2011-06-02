using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// TransitionKind is an enumeration type.
	/// </summary>
	public enum TransitionKind : int 
	{
		/// <summary>
		/// internal implies that the transition, if triggered, occurs without exiting or entering the source state. Thus, it does not
		/// cause a state change. This means that the entry or exit condition of the source state will not be invoked. An internal
		/// transition can be taken even if the state machine is in one or more regions nested within this state.
		/// </summary>
		_internal,
		
		/// <summary>
		/// local implies that the transition, if triggered, will not exit the composite (source) state, but it will apply to any state
		/// within the composite state, and these will be exited and entered.
		/// </summary>
		_local,
		
		/// <summary>
		/// external implies that the transition, if triggered, will exit the source vertex.
		/// </summary>
		_external

	}

}