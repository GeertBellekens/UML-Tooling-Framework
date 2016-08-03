
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of BaseDataType.
	/// </summary>
	public interface BaseDataType
	{
		string name {get;set;}
		bool hasLength {get;set;}
		bool hasPrecision {get;set;}
	}
}
