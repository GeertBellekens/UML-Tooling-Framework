using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Dependencies {
	public interface Abstraction : Dependency {
    UML.Classes.Kernel.OpaqueExpression mapping { get; set; }
	}
}
