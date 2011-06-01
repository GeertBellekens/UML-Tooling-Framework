using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.Activities.FundamentalActivities {
	/// <summary>
	/// An activity is the specification of parameterized behavior as the coordinated sequencing of subordinate units whose
	/// individual elements are actions. There are actions that invoke activities (directly by “CallBehaviorAction (from
	/// BasicActions)” or indirectly as methods by “CallOperationAction (from BasicActions)”).
	/// 		
	/// An activity specifies the coordination of executions of subordinate behaviors, using a control and data flow model. The
	/// subordinate behaviors coordinated by these models may be initiated because other behaviors in the model finish
	/// executing, because objects and data become available, or because events occur external to the flow. The flow of execution
	/// is modeled as activity nodes connected by activity edges. A node can be the execution of a subordinate behavior, such as
	/// an arithmetic computation, a call to an operation, or manipulation of object contents. Activity nodes also include flow-ofcontrol
	/// constructs, such as synchronization, decision, and concurrency control. Activities may form invocation hierarchies
	/// invoking other activities, ultimately resolving to individual actions. In an object-oriented model, activities are usually
	/// invoked indirectly as methods bound to operations that are directly invoked.
	/// Activities may describe procedural computation. In this context, they are the methods corresponding to operations on
	/// classes. Activities may be applied to organizational modeling for business process engineering and workflow. In this
	/// context, events often originate from inside the system, such as the finishing of a task, but also from outside the system,
	/// such as a customer call. Activities can also be used for information system modeling to specify system level processes.
	/// Activities may contain actions of various kinds:
	/// • Occurrences of primitive functions, such as arithmetic functions.
	/// • Invocations of behavior, such as activities.
	/// • Communication actions, such as sending of signals.
	/// • Manipulations of objects, such as reading or writing attributes or associations.
	/// </summary>
	public interface Activity : UML.CommonBehaviors.BasicBehaviors.Behavior {

		/// <summary>
		/// Top-level groups in the activity. {Subsets Namespace::ownedElement}
		/// </summary>
		HashSet<ActivityGroup> groups{get;set;}
		/// <summary>
		/// Nodes coordinated by the activity. {Subsets Namespace::ownedElement}
		/// </summary>
		HashSet<ActivityNode> nodes{get;set;}

	}
}