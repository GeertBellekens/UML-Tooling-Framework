namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface PackageMerge : DirectedRelationship {
    Package mergedPackage    { get; set; }
    Package receivingPackage { get; set; }
	}
}
