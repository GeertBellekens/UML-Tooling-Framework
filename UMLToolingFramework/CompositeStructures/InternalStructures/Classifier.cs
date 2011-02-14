using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CompositeStructures.InternalStructures {
	
    
    public interface  Classifier {

        //See 7.3.8, “Classifier (from Kernel, Dependencies, PowerTypes),” on page 53
        HashSet<Property> attributes { get; set; }

        //See 7.3.8, “Classifier (from Kernel, Dependencies, PowerTypes),” on page 53
        HashSet<UML.Classes.Kernel.Feature> features { get; set; } 
	}
}