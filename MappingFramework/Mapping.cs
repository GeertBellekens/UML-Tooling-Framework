
using System;
using UML=TSF.UmlToolingFramework.UML;

namespace MappingFramework
{
	/// <summary>
	/// Description of Mapping.
	/// </summary>
	public interface Mapping
	{
		MappingEnd source {get;set;}
		MappingEnd target {get;set;}
		MappingLogic mappingLogic {get;set;}
		void save();
	}
}
