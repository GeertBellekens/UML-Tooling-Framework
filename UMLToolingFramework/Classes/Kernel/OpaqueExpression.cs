using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface OpaqueExpression : ValueSpecification {
		List<string> bodies    { get; set; }
		List<string> languages { get; set; }
	}
}
