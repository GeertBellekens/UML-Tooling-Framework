using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// A special kind of state signifying that the enclosing region is completed. If the enclosing region is directly contained in a
	/// state machine and all other regions in the state machine also are completed, then it means that the entire state machine is
	/// completed.
	/// </summary>
	public interface FinalState : State 
	{

	}

}