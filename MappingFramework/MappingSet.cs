
using System;
using System.Collections.Generic;

namespace MappingFramework
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public interface MappingSet
	{
        MappingModel source { get; set; }
        MappingModel target { get; set; }
		List<Mapping> mappings {get;set;}
		void addMapping(Mapping mapping);
	}
}