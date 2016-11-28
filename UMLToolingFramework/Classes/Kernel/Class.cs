using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
  public interface Class : Classifier {
		HashSet<Property>   ownedAttributes   { get; set; }
		HashSet<Classifier> nestedClassifiers { get; set; }
		HashSet<Operation>  ownedOperations   { get; set; }
    	HashSet<Class>      superClasses      { get; set; }
    	HashSet<Class> 	subClasses {get;}
	}
}
