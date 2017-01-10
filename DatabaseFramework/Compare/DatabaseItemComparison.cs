
using System;
using System.Collections.Generic;


namespace DatabaseFramework.Compare
{
	/// <summary>
	/// Description of DatabaseItemComparison.
	/// </summary>
	public interface DatabaseItemComparison
	{
		DatabaseItem newDatabaseItem {get;set;}
		DatabaseItem existingDatabaseItem {get;set;}
		DatabaseComparisonStatusEnum comparisonStatus {get;set;}
		string comparisonStatusName {get;}
		string itemType{get;}
		void updatePosition(int i);
		void save(Database existingDatabase);
		DatabaseItemComparison ownerComparison {get;set;}
		List<DatabaseItemComparison> ownedComparisons {get;set;}
		DatabaseItemComparison addOwnedComparison(DatabaseItem existingItem, DatabaseItem newItem);
		void rename(string newName);
		bool isRenamed{get;}
		string renamedName{get;}
	}
}
