

using System;
using DB=DatabaseFramework;
using UML=TSF.UmlToolingFramework.UML;
using System.Collections.Generic;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of ColumnTransformer.
	/// </summary>
	public interface ColumnTransformer
	{
		Table table {get;set;}
		Column column {get;set;}
		UML.Classes.Kernel.Property logicalProperty {get;set;}
		Column transformLogicalProperty(UML.Classes.Kernel.Property attribute);
		/// <summary>
		/// save the changes from the transformer to the existing database
		/// </summary>
		void save();
	}
}
