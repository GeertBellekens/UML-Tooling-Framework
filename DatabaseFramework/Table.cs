
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Table.
	/// </summary>
	public interface Table:DatabaseItem
	{
		Database databaseOwner {get;set;}
		List<Column> columns {get;set;}
		List<Constraint> constraints {get;set;}
		PrimaryKey primaryKey {get;set;}
		List<ForeignKey> foreignKeys{get;set;}
		string tableSpace{get;set;}
		string tableOwner {get;set;}
		bool isAbstract{get;}

		void addColumn(Column column);
		void removeColumn(Column column);
		void removeColumn(Column column, Column replacement);

		void addConstraint(Constraint constraint);
		void removeConstraint(Constraint constraint);
    
    Constraint getConstraint(string name);
	}
}
