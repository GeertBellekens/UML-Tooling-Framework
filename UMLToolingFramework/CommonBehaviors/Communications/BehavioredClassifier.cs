using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {
	//A classifier can have behavior specifications defined in its namespace. One of these may specify the behavior of the
    //classifier itself.
    public interface  BehavioredClassifier {
        //References Trigger descriptions owned by a Classifier (Subsets Namespace::ownedMember)
		HashSet<Trigger> ownedTrigger{ get; set; }

	}

}