
using System;
using UML=TSF.UmlToolingFramework.UML;

namespace MappingFramework
{
	/// <summary>
	/// Description of AssociationMappingEnd.
	/// </summary>
	public interface AssociationMappingEnd:MappingEnd
	{
		UML.Classes.Kernel.Association mappedAssociation {get;set;}
	}
}
