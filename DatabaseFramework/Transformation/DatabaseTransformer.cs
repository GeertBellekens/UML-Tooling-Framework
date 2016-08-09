
using System;
using DB=DatabaseFramework;
using UML=TSF.UmlToolingFramework.UML;
using System.Collections.Generic;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of DatbaseTransformer.
	/// </summary>
	public interface DatabaseTransformer
	{
		DB.Database database {get;set;}
		UML.Classes.Kernel.Package logicalPackage {get;set;}
		List<TableTransformer> tableTransformers {get;set;}
		DB.Database transformLogicalPackage(UML.Classes.Kernel.Package logicalPackage);
		
	}
}
