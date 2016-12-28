using System.Collections.Generic;
using System.Linq;
using System;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel
{
	/// <summary>
	/// Description of Multiplicity.
	/// </summary>
	public interface Multiplicity
	{
		UnlimitedNatural upper { get; set; }
   		uint lower { get; set; }
	}
}
