
using System;


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
	}
}
