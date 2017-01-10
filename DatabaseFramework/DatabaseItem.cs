
using System;
using System.Collections.Generic;
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
		bool isRenamed {get;set;}
		void save();
		void delete();
		void update(DatabaseItem newDatabaseItem, bool save = true);
		DatabaseItem owner {get;}
		DataBaseFactory factory {get;}
		DatabaseItem createAsNewItem(DatabaseItem owner,bool save = true);
		DatabaseItem createAsNewItem(DatabaseItem owner,string newName,bool save = true);
		bool isValid{get;}
		List<UML.Classes.Kernel.Element> logicalElements {get;}
		void Select();
		int position {get;set;}
		DatabaseItem derivedFromItem {get;set;}
		string renamedName{get;set;}
	}
}
