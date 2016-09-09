

using System;
using DB=DatabaseFramework;
using UML=TSF.UmlToolingFramework.UML;
using System.Collections.Generic;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of ColumnTransformer.
	/// </summary>
	public interface ColumnTransformer:DatabaseItemTransformer
	{
		Table table {get;set;}
		Column column {get;set;}
		UML.Classes.Kernel.Property logicalProperty {get;set;}
		Column transformLogicalProperty(UML.Classes.Kernel.Property attribute);
		
	}
}
