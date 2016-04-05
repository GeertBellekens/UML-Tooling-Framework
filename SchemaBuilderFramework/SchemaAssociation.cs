
using System;
using UML=TSF.UmlToolingFramework.UML;
using System.Collections.Generic;


namespace SchemaBuilderFramework
{
	/// <summary>
	/// Description of SchemaAssociation.
	/// </summary>
	public interface SchemaAssociation
	{
		UML.Classes.Kernel.Association sourceAssociation {get;set;}
		List<UML.Classes.Kernel.Association> subsetAssociations {get;set;}
		List<SchemaElement> relatedElements {get;set;}
		SchemaElement owner {get;set;}
		/// <summary>
		/// the schema element on the other side of the association
		/// </summary>
		SchemaElement otherElement {get;set;}
		void createSubsetAssociation();
		/// <summary>
		/// returns the end of the schema association's source association that is on the owner side
		/// </summary>
		UML.Classes.Kernel.Property thisEnd {get;set;}
		/// <summary>
		/// returns the end of the schema association's source association that is on the other side
		/// </summary>
		UML.Classes.Kernel.Property otherEnd {get;set;}
	}
}
