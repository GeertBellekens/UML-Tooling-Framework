
using System;
using UML=TSF.UmlToolingFramework.UML;

namespace SchemaBuilderFramework
{
	/// <summary>
	/// Description of SchemaProperty.
	/// </summary>
	public interface SchemaProperty
	{
		UML.Classes.Kernel.Property sourceProperty {get;set;}
		SchemaElement owner {get;set;}
	}
}
