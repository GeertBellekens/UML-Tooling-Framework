
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Column.
	/// </summary>
	public interface Column:DatabaseItem
	{
		Table ownerTable {get;set;}
		DataType type {get;set;}
		bool isNotNullable {get;set;}
	}
}
