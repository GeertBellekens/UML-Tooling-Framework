
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of BaseDataType.
	/// </summary>
	public interface BaseDataType:DatabaseItem
	{
		bool hasLength {get;set;}
		bool hasPrecision {get;set;}
        string databaseProduct { get; }
    }
}
