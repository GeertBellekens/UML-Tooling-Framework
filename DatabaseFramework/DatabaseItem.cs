
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
		bool isOverridden {get;set;}
		void save();
		void delete();
		void update(DatabaseItem newDatabaseItem, bool save = true);
		DatabaseItem owner {get;}
		DataBaseFactory factory {get;}
		void createAsNewItem(Database existingDatabase);
		bool isValid{get;}
	}
}
