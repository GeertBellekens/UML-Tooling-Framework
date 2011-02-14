using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.Communications
{
    //A signal is a specification of send request instances communicated between objects. The receiving object handles the
    //received request instances as specified by its receptions. The data carried by a send request (which was passed to it by the
    //send invocation occurrence that caused that request) are represented as attributes of the signal. A signal is defined
    //independently of the classifiers handling the signal occurrence.
	public interface Signal : UML.Classes.Kernel.Classifier {

        //The attributes owned by the signal. (Subsets Classifier::attribute, Namespace::ownedMember). This association end
        //is ordered.
		HashSet<UML.Classes.Kernel.Property> ownedAttributes{ get; set; }

	}

}