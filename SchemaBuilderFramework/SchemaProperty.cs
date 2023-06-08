
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
		UML.Classes.Kernel.Property subSetProperty {get;set;}
		UML.Classes.Kernel.EnumerationLiteral sourceLiteral { get; set; }
		UML.Classes.Kernel.EnumerationLiteral subSetLiteral { get; set; }
		SchemaElement owner {get;set;}
		void createSubsetProperty();
		bool isNew {get;}
	}
}
