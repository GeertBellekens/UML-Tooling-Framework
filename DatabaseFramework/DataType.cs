
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of DataType.
	/// </summary>
	public interface DataType
	{
		BaseDataType type {get;set;}
		string name {get;}
		int length {get;set;}
		int precision {get;set;}
			
	}
}
