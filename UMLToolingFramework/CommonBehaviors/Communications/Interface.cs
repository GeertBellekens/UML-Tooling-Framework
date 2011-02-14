using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications {

    //Adds the capability for interfaces to include receptions (in addition to operations).
    public interface Interface : UML.Classes.Interfaces.Interface {

        //Receptions that objects providing this interface are willing to accept. (Subsets Namespace::ownedMember and
        //Classifier::feature)
		HashSet<Reception> ownedReceptions{ get; set; }

	}
}