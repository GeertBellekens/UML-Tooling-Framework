using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML = TSF.UmlToolingFramework.UML;

namespace MappingFramework
{
    public interface MappingNode
    {
        string name { get; }
        UML.Classes.Kernel.NamedElement source { get; set; }
        IEnumerable<MappingNode> childNodes { get; set; }
        MappingNode parent { get; set; }
        IEnumerable<Mapping> getMappings(MappingNode targetRootNode);
        void addChildNode(MappingNode childNode);

    }
}
