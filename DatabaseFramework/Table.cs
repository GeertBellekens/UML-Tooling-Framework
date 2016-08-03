
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Table.
	/// </summary>
	public interface Table
	{
		string name {get;set;}
		Database owner {get;set;}
		List<Column> columns {get;set;}
		List<Constraint> constraints {get;set;}
	}
}
