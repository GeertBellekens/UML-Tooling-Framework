using System;

namespace TSF.UmlToolingFramework.UML
{
	/// <summary>
	/// a UML Item is an object from the UML world that can be part of a UML model
	/// </summary>
	public interface UMLItem
	{
		/// <summary>
		/// selects this item in the tool
		/// </summary>
		void select();
		/// <summary>
		/// opens this item in the tool
		/// </summary>
		void open();
		/// <summary>
		/// the name of the item
		/// </summary>
		string name {get;}
		/// <summary>
		/// the owner of the item
		/// </summary>
		UML.Classes.Kernel.Element owner {get;set;}
		/// <summary>
		/// the fully qualified name of the item.
		/// contains the full node path from the root of the model to this item.
		/// </summary>
		string fqn {get;}
		/// <summary>
		/// opens the properties diaglog for this item
		/// </summary>
		void openProperties();
	}
}
