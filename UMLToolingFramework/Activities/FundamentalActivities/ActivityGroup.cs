using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.Activities.FundamentalActivities {
	/// <summary>
	/// Activity groups are a generic grouping construct for nodes and edges. Nodes and edges can belong to more than one
	/// group. They have no inherent semantics and can be used for various purposes. Subclasses of ActivityGroup may add
	/// semantics.
	/// </summary>
	public interface  ActivityGroup : UML.Classes.Kernel.NamedElement {

		/// <summary>
		/// Activity containing the group. {Subsets NamedElement::owner}
		/// </summary>
		Activity inActivity{get;set;}
		
		/// <summary>
		/// Nodes immediately contained in the group. This is a derived union.
		/// </summary>
		HashSet<ActivityNode> containedNodes{get;set;}
		
		/// <summary>
		/// Group immediately containing the group.
		/// </summary>
		ActivityGroup supergroup{get;set;}
		
		/// <summary>
		/// Groups immediately contained in the group.
		/// </summary>
		HashSet<ActivityGroup> subgroups{get;set;}
		

	}
}