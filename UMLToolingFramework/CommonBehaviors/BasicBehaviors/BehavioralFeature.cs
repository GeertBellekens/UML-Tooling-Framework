using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.BasicBehaviors
{
    //A behavioral feature is implemented (realized) by a behavior. A behavioral feature specifies that a classifier will respond
    //to a designated request by invoking its implementing method.
	public interface  BehavioralFeature {
        
        //If true, then the behavioral feature does not have an implementation, and one must be supplied by a more specific
        //element. If false, the behavioral feature must have an implementation in the classifier or one must be inherited
        //from a more general element. Default value is false.
		 bool isAbstract{ get; set; }
        
        //A behavioral description that implements the behavioral feature. There may be at most one behavior for a particular
        //pairing of a classifier (as owner of the behavior) and a behavioral feature (as specification of the behavior).
		 HashSet<Behavior> methods{ get; set; }

	}
}