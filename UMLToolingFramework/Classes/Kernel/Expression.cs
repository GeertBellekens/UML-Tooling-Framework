using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Expression : ValueSpecification {
	  string symbol { get; set; }
    List<ValueSpecification> operand { get; set; }
	}
}
