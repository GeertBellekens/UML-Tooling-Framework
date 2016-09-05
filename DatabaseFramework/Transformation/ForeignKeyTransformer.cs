

using System;
using DB=DatabaseFramework;
using UML=TSF.UmlToolingFramework.UML;
using System.Collections.Generic;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of ForeignKeyTransformer.
	/// </summary>
	public interface ForeignKeyTransformer
	{
		DB.ForeignKey foreignKey {get;set;}
		UML.Classes.Kernel.Association logicalAssociation {get;set;}
		void resetName();

	}
}
