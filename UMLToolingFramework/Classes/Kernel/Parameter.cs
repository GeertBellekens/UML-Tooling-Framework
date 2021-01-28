using System; 

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Parameter : MultiplicityElement, TypedElement 
	{
		ParameterDirectionKind direction { get; set; }
		String _default { get; set; }
		ValueSpecification defaultValue { get; set; }
    	Operation operation { get; set; }
	}
}
