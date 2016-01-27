
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
		/// <summary>
		/// updates the subset model linked to given messageElement
		/// </summary>
		/// <param name="messageElement">The message element that is the root for the message subset model</param>
		void updateSubsetModel(UML.Classes.Kernel.Class messageElement);
		/// <summary>
		/// list of tagged value names to ignore when updating tagged values
		/// </summary>
		List<string> ignoredStereotypes{get;set;}
		/// <summary>
		/// list of stereotypes of elements to ignore when updating a subset model
		/// </summary>
		List<string> ignoredTaggedValues{get;set;}
	}
}