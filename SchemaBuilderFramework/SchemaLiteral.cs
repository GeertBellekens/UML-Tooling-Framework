
using System;
using UML=TSF.UmlToolingFramework.UML;

namespace SchemaBuilderFramework
{
	/// <summary>
	/// Description of SchemaLiteral.
	/// </summary>
	public interface SchemaLiteral
	{
		UML.Classes.Kernel.EnumerationLiteral sourceLiteral {get;set;}
		UML.Classes.Kernel.EnumerationLiteral subSetLiteral {get;set;}
		SchemaElement owner {get;set;}
		void createSubsetLiteral();
	}
}
