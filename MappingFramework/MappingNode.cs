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
        ModelStructure structure { get; set; }
        UML.Classes.Kernel.NamedElement source { get; set; }
        IEnumerable<MappingNode> childNodes { get; }
        IEnumerable<MappingNode> mappedChildNodes { get; }
        IEnumerable<MappingNode> allChildNodes { get; }
        bool showAll {get;set; }
        bool isMapped { get;}
        MappingNode parent { get; set; }
        IEnumerable<Mapping> getMappings(MappingNode targetRootNode);
        void addChildNode(MappingNode childNode);
        IEnumerable<Mapping> mappings { get; }
        void addMapping(Mapping mapping);
        void setChildNodes();
    }
}
