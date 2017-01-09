
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
		void removeColumn(Column column);
		void removeColumn(Column column, Column replacement);
	}
}
