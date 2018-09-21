
using System;
using System.Collections.Generic;

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
	}
}