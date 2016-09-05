
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
		DB.Database newDatabase {get;set;}
		UML.Classes.Kernel.Package logicalPackage {get;set;}
		List<TableTransformer> tableTransformers {get;set;}
		UML.Extended.UMLModel model {get;set;}
		DB.Database transformLogicalPackage(UML.Classes.Kernel.Package logicalPackage);
		DB.Database existingDatabase {get;set;}
		void refresh();
		
	}
}
