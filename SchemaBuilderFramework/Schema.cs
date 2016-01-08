
using System;
using System.Collections.Generic;
using UML=TSF.UmlToolingFramework.UML;

namespace SchemaBuilderFramework
{
	/// <summary>
	/// A Schema is the represenation of a part of the model that can be used as a message
	/// </summary>
	public interface Schema
	{
		/// <summary>
		/// the SchemaElements owned by this schema
		/// </summary>
		HashSet<SchemaElement> elements {get;set;}
		/// <summary>
		/// creates a subset of the source model with only the properties and associations used in this schema
		/// </summary>
		/// <param name="destinationPackage">the package to create the subset in</param>
		void createSubsetModel(UML.Classes.Kernel.Package destinationPackage);
	}
}