using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface InstanceSpecification : PackageableElement {
    ValueSpecification  specification  { get; set; }
    HashSet<Slot>       slots          { get; set; }
    List<InstanceValue> instanceValues { get; set; }
    HashSet<Classifier> classifiers    { get; set; }
	}
}
