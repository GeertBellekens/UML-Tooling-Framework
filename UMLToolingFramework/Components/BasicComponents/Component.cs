

using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.Components.BasicComponents
{
    public interface Component : UML.Classes.Kernel.Class
    {

        bool isIndirectlyInstantiated { get; set; }
        //public UML.Components.BasicComponents.Realization /realization;
		HashSet<UML.Classes.Interfaces.Interface> required { get; set; }
        HashSet<UML.Classes.Interfaces.Interface> provided { get; set; }
    }

}