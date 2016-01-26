namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  PackageableElement : NamedElement 
	{
		Package owningPackage {get;set;}
	}
}
