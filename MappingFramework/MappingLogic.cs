
using System;
using UML=TSF.UmlToolingFramework.UML;
namespace MappingFramework
{
	/// <summary>
	/// Description of MappingLogic.
	/// </summary>
	public interface MappingLogic
	{
		string description {get;set;}
		UML.Classes.Kernel.Element mappingElement{get;set;}
        void delete();
    }
}
