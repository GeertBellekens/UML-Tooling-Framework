using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.BasicBehaviors
{
    //A classifier can have behavior specifications defined in its namespace. One of these may specify the behavior of the
    //classifier itself.
	public interface  BehavioredClassifier : UML.Classes.Kernel.Classifier {

        //References behavior specifications owned by a classifier. (Subsets Namespace::ownedMember)
		 HashSet<Behavior> ownedBehaviors{ get; set; }

        //A behavior specification that specifies the behavior of the classifier itself. (Subsets
        //BehavioredClassifier::ownedBehavior)
		 Behavior classifierBehavior{ get; set; }

	}

}