
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Constraint.
	/// </summary>
	public interface Constraint
	{
		string name {get;set;}
		Table owner {get;set;}
		List<Column> involvedColumns {get;set;}
	}
}
