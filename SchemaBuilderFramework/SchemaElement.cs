
using System;
using System.Collections.Generic;
using UML=TSF.UmlToolingFramework.UML;

namespace SchemaBuilderFramework
{
	/// <summary>
	/// Description of SchemaElement.
	/// </summary>
	public interface SchemaElement
	{
		UML.Classes.Kernel.Classifier sourceElement {get;set;}
		Schema owner {get;set;}
		HashSet<SchemaProperty> schemaProperties {get;set;}
		HashSet<SchemaAssociation> schemaAssociations {get;set;}
	}
}
