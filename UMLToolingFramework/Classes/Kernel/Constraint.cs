using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel
{
    public interface Constraint : PackageableElement
    {
        HashSet<Element> constrainedElement { get; set; }
        ValueSpecification specification { get; set; }
        Namespace context { get; set; }
        string constraintType { get; set; }
    }
}
