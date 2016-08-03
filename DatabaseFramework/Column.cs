
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Column.
	/// </summary>
	public interface Column
	{
		Table owner {get;set;}
		string name {get;set;}
		DataType type {get;set;}
		bool isNotNullable {get;set;}
	}
}
