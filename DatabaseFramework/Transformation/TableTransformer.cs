
using System;
using DB=DatabaseFramework;
using UML=TSF.UmlToolingFramework.UML;
using System.Collections.Generic;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of TableTransformer.
	/// </summary>
	public interface TableTransformer
	{
		/// <summary>
		/// the database in which the tables are made
		/// </summary>
		Database database {get;set;}
		/// <summary>
		/// the resulting table
		/// </summary>
		Table table {get;set;}
		/// <summary>
		/// the logical classes from which the table was transformed
		/// </summary>
		List<UML.Classes.Kernel.Class> logicalClasses {get;set;}
		/// <summary>
		/// transforms the given classes into a single table
		/// </summary>
		/// <param name="logicalClasses">the logical classes for wich to create a table</param>
		/// <returns>the created table</returns>
		Table transformLogicalClasses(List<UML.Classes.Kernel.Class> logicalClasses);
		Table transformLogicalClass(UML.Classes.Kernel.Class logicalClass);
		List<ColumnTransformer> columnTransformers {get;set;}
	}
}
