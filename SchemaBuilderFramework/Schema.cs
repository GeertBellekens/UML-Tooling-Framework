
using System;
using System.Collections.Generic;
using TSF.UmlToolingFramework.UML.Classes.Kernel;
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
	    void createSubsetModel(Package destinationPackage, HashSet<SchemaElement> elements);

	    /// <summary>
	    /// updates the subset model linked to given messageElement
	    /// </summary>
	    /// <param name="messageElement">The message element that is the root for the message subset model</param>
	    void updateSubsetModel(Classifier messageElement);
		
	    /// <summary>
	    /// updates the subset model linked to given messageElement
	    /// </summary>
	    /// <param name="destinationPackage">the package to create the subset in</param>
	    void updateSubsetModel(Package destinationPackage);
	    
	    /// <summary>
	    /// the settings this schema has to work with
	    /// </summary>
	    SchemaSettings settings {get;set;}
	    
	    /// <summary>
	    /// the name of the schema
	    /// </summary>
	    string name {get;}

        /// <summary>
        /// the UML element containing the schema
        /// </summary>
        PackageableElement containerElement { get; set; }
	}
}