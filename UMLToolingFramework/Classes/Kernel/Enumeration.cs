using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Enumeration : DataType {
		HashSet<EnumerationLiteral> ownedLiterals { get; set; }
	}
}
