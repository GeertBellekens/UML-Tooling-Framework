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
	}
}
