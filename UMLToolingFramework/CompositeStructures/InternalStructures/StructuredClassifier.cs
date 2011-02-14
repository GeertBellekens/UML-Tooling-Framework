using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CompositeStructures.InternalStructures {
	
    //A structured classifier is an abstract metaclass that represents any classifier whose behavior can be fully or partly
    //described by the collaboration of owned or referenced instances.
    public interface  StructuredClassifier : Classifier {

        //References the roles that instances may play in this classifier. (Abstract union; subsets Classifier::feature)
        HashSet<ConnectableElement> roles { get; set; }

        //References the properties owned by the classifier. (Subsets StructuredClassifier::role, Classifier::attribute, and
        //Namespace::ownedMember)
        HashSet<Property> ownedAttributes { get; set; }

        //References the properties specifying instances that the classifier owns by composition. This association is derived,
        //selecting those owned properties where isComposite is true.
		HashSet<Property> parts {get; set;}

        //References the connectors owned by the classifier. (Subsets Classifier::feature and Namespace::ownedMember)
		HashSet<Connector> ownedConnectors {get; set;}
	}
}