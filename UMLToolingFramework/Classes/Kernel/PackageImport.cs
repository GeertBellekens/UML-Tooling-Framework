namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface PackageImport : DirectedRelationship {
    VisibilityKind visibility         { get; set; }
    Package        importedPackage    { get; set; }
    Namespace      importingNameSpace { get; set; }
	}
}
