using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.Activities.FundamentalActivities {
	/// <summary>
	/// An activity node is an abstract class for the steps of an activity. It covers executable nodes, control nodes, and object
	/// nodes.
	/// </summary>
	public interface  ActivityNode : UML.Classes.Kernel.NamedElement,UML.Classes.Kernel.RedefinableElement {

		/// <summary>
		/// Activity containing the node. {Subsets NamedElement::owner}
		/// </summary>
		Activity activity{get;set;}
		
		/// <summary>
		/// Groups containing the node. Multiplicity specialized to [0..1] for StructuredActivityGroup.
		/// </summary>
		HashSet<ActivityGroup> inGroups{get;set;}

	}

}