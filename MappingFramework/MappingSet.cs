
using System;
using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace MappingFramework
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public interface MappingSet
	{
        MappingNode source { get; set; }
        MappingNode target { get; set; }
		IEnumerable<Mapping> mappings {get;set;}
		void addMapping(Mapping mapping);
        IEnumerable<UML.Classes.Kernel.NamedElement> contexts { get;}
        void loadAllMappings();
        void loadMappings(UML.Classes.Kernel.NamedElement sourceElement);
	}
}