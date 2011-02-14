using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface DataType : Classifier {
    HashSet<Operation> ownedOperations { get; set; }
    HashSet<Property>  ownedAttributes { get; set; }
	}
}
