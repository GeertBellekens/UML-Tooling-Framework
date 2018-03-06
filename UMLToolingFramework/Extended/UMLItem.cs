using System;
using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Extended
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
        List<UML.Classes.Kernel.Element> getAllOwners();
        /// <summary>
        /// the fully qualified name of the item.
        /// contains the full node path from the root of the model to this item.
        /// </summary>
        string fqn {get;}
		/// <summary>
		/// returns the unique ID of this item.
		/// </summary>
		string uniqueID {get;}
		/// <summary>
		/// opens the properties diaglog for this item
		/// </summary>
		void openProperties();
		/// <summary>
		/// the stereotypes on this element
		/// </summary>
		HashSet<UML.Profiles.Stereotype> stereotypes{get;}
		/// <summary>
		/// add this element to the currently opened diagram
		/// </summary>
		void addToCurrentDiagram();
		/// <summary>
		/// select this element in the currently opened diagram
		/// </summary>
		void selectInCurrentDiagram();
		/// <summary>
		/// deletes this element from the model
		/// </summary>
		void delete();
		/// <summary>
		/// save the changes to this item
		/// </summary>
		void save();
		/// <summary>
		/// returns a list of diagrams that show this item
		/// </summary>
		/// <returns>all diagrams that show this item</returns>
		List<UML.Diagrams.Diagram> getDependentDiagrams();
		/// <summary>
        /// indicates if this diagram is readOnly and cannot be modified at this moment
        /// </summary>
       	bool isReadOnly {get;}
       	/// <summary>
       	/// makes the diagram writable.
       	/// </summary>
       	/// <param name="overrideLocks">indicates if current locks should be overrridden</param>
       	/// <returns>true if successful</returns>
	    bool makeWritable(bool overrideLocks);
	}
}
