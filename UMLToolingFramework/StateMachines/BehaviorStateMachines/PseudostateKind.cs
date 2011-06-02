
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.StateMachines.BehaviorStateMachines 
{
	/// <summary>
	/// PseudostateKind is an enumeration type.
	/// </summary>
	public enum PseudostateKind : int 
	{

		initial,
		deepHistory,
		shallowHistory,
		join,
		fork,
		junction,
		choice,
		entryPoint,
		exitPoint,
		terminate

	}

}