
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
		List<SchemaElement> relatedElements {get;set;}
		SchemaElement owner {get;set;}
	}
}
