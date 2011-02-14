using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Relationship : Element {
    List<Element> relatedElements { get; set; }
	}
}
