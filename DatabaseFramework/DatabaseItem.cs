
using System;
using UML = TSF.UmlToolingFramework.UML;

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
		DatabaseItem createAsNewItem(Database existingDatabase,bool save = true);
		bool isValid{get;}
		UML.Classes.Kernel.Element logicalElement {get;}
		void Select();
		int position {get;set;}
	}
}
