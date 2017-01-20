using System.Collections.Generic;
using TSF.UmlToolingFramework.UML.Extended;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Namespace : NamedElement 
	{
		HashSet<UML.Diagrams.Diagram> ownedDiagrams {get;set;}
		UMLItem findOwnedItem(string itemDescriptor);
	}
}
