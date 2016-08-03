
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of ForeignKey.
	/// </summary>
	public interface ForeignKey:Constraint
	{
		Table foreignTable {get;set;}
		
	}
}
