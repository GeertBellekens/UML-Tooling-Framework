namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  StructuralFeature : Feature, 
	                                      TypedElement, 
	                                      MultiplicityElement 
  {
    bool isReadOnly { get; set; }
	}
}
