namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Slot : Element {
    StructuralFeature     definingFeature { get; set; }
    InstanceSpecification owningInstance  { get; set; }
    ValueSpecification    value           { get; set; }
	}
}
