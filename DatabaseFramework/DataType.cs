
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of DataType.
	/// </summary>
	public interface DataType:DatabaseItem
	{
		BaseDataType type {get;set;}
		int length {get;set;}
		int precision {get;set;}
			
	}
}
