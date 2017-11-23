
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
		//TODO:?List<DatabaseItem> ownedItems{get;set;}
		DataBaseFactory factory {get;}
		DatabaseItem createAsNewItem(DatabaseItem owner,bool save = true);
		DatabaseItem createAsNewItem(DatabaseItem owner,string newName,bool save = true);
		List<DatabaseItem> mergedEquivalents {get;set;}
		bool isValid{get;}
		List<UML.Classes.Kernel.Element> logicalElements {get;}
		void Select();
		int position {get;set;}
		DatabaseItem derivedFromItem {get;set;}
		string renamedName{get;set;}
		/// <summary>
		/// indicates wether this column is not to be realized in the physical database.
		/// Will be true when a logical column with no physical counterpart is being overridden.
		/// Thas means that this column will be realized as a physical column in the databae
		/// </summary>
		bool isNotRealized{get;set;}
		bool isEqualDirty{get;set;}
	}
}
