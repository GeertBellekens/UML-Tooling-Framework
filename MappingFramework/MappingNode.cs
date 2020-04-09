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
        string displayName { get; }
        ModelStructure structure { get; set; }
        UML.Classes.Kernel.NamedElement source { get; set; }
        UML.Classes.Kernel.NamedElement virtualOwner { get; set; }
        bool isVirtual { get; }
        IEnumerable<MappingNode> childNodes { get; }
        IEnumerable<MappingNode> mappedChildNodes { get; }
        IEnumerable<MappingNode> allChildNodes { get; }
        bool showAll {get;set; }
        bool isMapped { get;}
        MappingNode parent { get; set; }
        IEnumerable<Mapping> getMappings();
        IEnumerable<Mapping> getMyMappings();
        void addChildNode(MappingNode childNode);
        IEnumerable<Mapping> mappings { get; }
        void addMapping(Mapping mapping);
        void removeMapping(Mapping mapping);
        void setChildNodes();
        Mapping mapTo(MappingNode targetNode);
        bool isChildOf(MappingNode parentNode);
        bool isChildOf(string uniqueID);
        Mapping createEmptyMapping(bool reverse);
        MappingNode findNode(List<string> mappingPathNames);
        bool isReadOnly { get; }
        MappingSet mappingSet { get; set;}
        string getMappingPathString();
        bool isTarget { get; set; }
    }
}
