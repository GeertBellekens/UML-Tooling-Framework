namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface ElementImport : DirectedRelationship {
		VisibilityKind visibility          { get; set; }
		string alias                       { get; set; }
		PackageableElement importedElement { get; set; }
    Namespace importingNamespace       { get; set; }
	}
}
