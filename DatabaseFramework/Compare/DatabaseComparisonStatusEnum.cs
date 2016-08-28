
using System;

namespace DatabaseFramework.Compare
{
	public enum DatabaseComparisonStatusEnum : int
	{
		equal,
		newItem,
		deletedItem,
		changed,
		dboverride
	}	
}