
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of DatabaseItem.
	/// </summary>
	public interface DatabaseItem
	{
		string name {get;set;}
		string itemType {get;}
		string properties {get;}
	}
}
