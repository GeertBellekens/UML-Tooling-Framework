using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface InstanceSpecification : PackageableElement {
    ValueSpecification  specification  { get; set; }
    HashSet<Slot>       slots          { get; set; }
    List<InstanceValue> instanceValues { get; set; }
    HashSet<Classifier> classifiers    { get; set; }
    bool? booleanValue();
    int? integerValue();
    bool isComputable();
    bool isNull();
    double? realValue();
    string stringValue();
    UnlimitedNatural unlimitedValue();
	}
}
