using System.Collections.Generic;

using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  NamedElement : Element {
		string         name            { get; set; }
    VisibilityKind visibility      { get; set; }
    string         qualifiedName   { get; set; }
    Namespace      owningNamespace { get; set; }

    /// Indicates the dependencies that reference the client.
    List<UML.Classes.Dependencies.Dependency> clientDependencies 
      { get; set; }

    /// Convienience operation (non UML standard)
    /// Indicates the dependencies that reference the supplier.
    List<UML.Classes.Dependencies.Dependency> supplierDependencies 
      { get; set; }
	}
}
