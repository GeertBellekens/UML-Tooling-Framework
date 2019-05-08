
using System;
using System.Collections.Generic;
using UML=TSF.UmlToolingFramework.UML;

namespace MappingFramework
{
	/// <summary>
	/// Description of Mapping.
	/// </summary>
	public interface Mapping
	{
		MappingNode source {get;set;}
        MappingNode target {get;set;}
		IEnumerable<MappingLogic> mappingLogics { get; set; }
        void addMappingLogic(MappingLogic mappingLogic);
        void removeMappingLogic(MappingLogic mappingLogic);
        bool isEmpty { get; set; }
        bool isReverseEmpty { get; set; }
        bool isReadOnly { get; }

        void save();
        void delete();
    }
}
