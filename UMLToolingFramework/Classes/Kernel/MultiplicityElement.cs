namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  MultiplicityElement : Element {
    bool isOrdered { get; set; }
    bool isUnique { get; set; }
    UnlimitedNatural upper { get; set; }
    uint lower { get; set; }
    ValueSpecification upperValue { get; set; }
    ValueSpecification lowerValue { get; set; }
	}
}
