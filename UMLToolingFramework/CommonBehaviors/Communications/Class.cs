using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {
	
    public interface Class : BehavioredClassifier,UML.Classes.Kernel.Class {

        //Determines whether an object specified by this class is active or not. If true, then the owning class is referred to as
        //an active class. If false, then such a class is referred to as a passive class. Default value is false.
		bool isActive{ get; set; }
   
        //Receptions that objects of this class are willing to accept. (Subsets Namespace::ownedMember and
        //Classifier::feature)
		HashSet<Reception> ownedReceptions{ get; set; }

	}
}