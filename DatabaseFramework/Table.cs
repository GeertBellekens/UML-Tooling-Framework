
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Table.
	/// </summary>
	public interface Table:DatabaseItem
	{
		Database owner {get;set;}
		List<Column> columns {get;set;}
		List<Constraint> constraints {get;set;}
		PrimaryKey primaryKey {get;set;}
		List<ForeignKey> foreignKeys{get;set;}

		void addColumn(Column column);
	}
}
