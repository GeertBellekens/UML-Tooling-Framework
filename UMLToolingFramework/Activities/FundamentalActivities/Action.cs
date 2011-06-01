using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.Activities.FundamentalActivities {
	/// <summary>
	/// An action represents a single step within an activity, that is, one that is not further decomposed within the activity. An
	/// activity represents a behavior that is composed of individual elements that are actions. Note, however, that a call behavior
	/// action may reference an activity definition, in which case the execution of the call action involves the execution of the
	/// referenced activity and its actions (similarly for all the invocation actions). An action is therefore simple from the point
	/// of view of the activity containing it, but may be complex in its effect and not be atomic. As a piece of structure within an
	/// activity model, it is a single discrete element; as a specification of behavior to be performed, it may invoke referenced
	/// behavior that is arbitrarily complex. As a consequence, an activity defines a behavior that can be reused in many places,
	/// whereas an instance of an action is only used once at a particular point in an activity.
	/// An action may have sets of incoming and outgoing activity edges that specify control flow and data flow from and to
	/// other nodes. An action will not begin execution until all of its input conditions are satisfied. The completion of the
	/// execution of an action may enable the execution of a set of successor nodes and actions that take their inputs from the
	/// outputs of the action.
	/// </summary>
	public interface Action : ActivityNode,UML.Actions.BasicActions.Action {
		
		/// <summary>
		/// If true, the action can begin a new, concurrent execution, even if there is already another execution of the action
		/// ongoing. If false, the action cannot begin a new execution until any previous execution has completed. The default is
		/// false.
		/// </summary>
		bool isLocallyReentrant {get;set;}
	}
}