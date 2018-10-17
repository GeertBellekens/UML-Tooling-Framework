
using System;
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
		MappingLogic mappingLogic {get;set;}
        string mappingLogicDescription { get; set; }
		void save();
        void delete();
    }
}
