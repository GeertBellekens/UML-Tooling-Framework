namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  ValueSpecification : PackageableElement, TypedElement {
    string Type  { get; set; }
    string Value { get; set; }
	}
}
