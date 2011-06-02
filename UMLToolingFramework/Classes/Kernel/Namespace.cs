using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Namespace : NamedElement 
	{
		HashSet<UML.Diagrams.Diagram> ownedDiagrams {get;set;}
	}
}
