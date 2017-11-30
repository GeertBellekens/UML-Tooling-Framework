
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// A database contains tables, stored procedures, users, etc...
	/// </summary>
	public interface Database:DatabaseItem
	{
		string type {get;set;}
		DataBaseFactory databaseFactory {get;set;}
		List<Table> tables {get;set;}
		Table getTable(string name);
		void addTable(Table table);
		void removeTable(Table table);
		Table getCorrespondingTable(Table externalTable);
		List<View> views {get;set;}
		void addView(View view);
		void removeView(View view);
    	string defaultOwner {get;set;}
	}
}
