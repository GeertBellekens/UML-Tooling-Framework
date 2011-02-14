using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Profiles {
    /// According to the UML specs the Stereotype is not really a 
    /// NamedElement, but for the sake of simplicity we have let it derive
    /// from NamedElement. Still to be seen if that is a wise choice.
    public interface Stereotype : UML.Classes.Kernel.NamedElement {}
}
