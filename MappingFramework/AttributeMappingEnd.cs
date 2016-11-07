
using System;
using UML=TSF.UmlToolingFramework.UML;

namespace MappingFramework
{
	/// <summary>
	/// Description of AttributeMappingEnd.
	/// </summary>
	public interface AttributeMappingEnd:MappingEnd
	{
		UML.Classes.Kernel.Property mappedAttribute {get;set;}
	}
}
