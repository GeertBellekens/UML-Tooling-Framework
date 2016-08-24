
using System;
using System.Collections.Generic;

namespace DatabaseFramework.Compare
{
	/// <summary>
	/// Description of DatabaseComparer.
	/// </summary>
	public interface DatabaseComparer
	{
		Database newDatabase {get;set;}
		Database existingDatabase {get;set;}
		List<DatabaseItemComparison> comparedItems {get;set;}
		void compare();
	}
}
