

using System;
using DB=DatabaseFramework;
using UML=TSF.UmlToolingFramework.UML;
using System.Collections.Generic;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of ForeignKeyTransformer.
	/// </summary>
	public interface ForeignKeyTransformer:DatabaseItemTransformer
	{
		DB.ForeignKey foreignKey {get;set;}
		UML.Classes.Kernel.Association logicalAssociation {get;}
		UML.Classes.Kernel.Property logicalAssociationEnd {get;set;}
		void resetName();

	}
}
