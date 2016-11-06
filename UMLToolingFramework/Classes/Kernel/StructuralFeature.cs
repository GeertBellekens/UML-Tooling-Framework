namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  StructuralFeature : Feature, 
	                                      TypedElement, 
	                                      MultiplicityElement 
  {
    bool isUMLReadOnly { get; set; }
	}
}
