
using System;
using UML=TSF.UmlToolingFramework.UML;

namespace MappingFramework
{
	/// <summary>
	/// Description of MappingEnd.
	/// </summary>
	public interface MappingEnd
	{
		//the mappedEnd will either be an association or an Attribute
		UML.Classes.Kernel.Element mappedEnd {get;set;}
		/// <summary>
		/// The path from the root element to the owner/source of the end, excluding the end
		/// </summary>
		string mappingPath {get;set;}
		/// <summary>
		/// The path from the root element to the end, indcluding the end itself.
		/// </summary>
		string fullMappingPath {get;}
	}
}
