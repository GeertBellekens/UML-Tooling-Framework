
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Constraint.
	/// </summary>
	public interface Constraint:DatabaseItem
	{
		Table ownerTable {get;set;}
		List<Column> involvedColumns {get;set;}
	}
}
