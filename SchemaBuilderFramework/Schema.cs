
using System;
using System.Collections.Generic;
using UML=TSF.UmlToolingFramework.UML;

namespace SchemaBuilderFramework
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public interface Schema
	{
		HashSet<SchemaElement> elements {get;set;}
	}
}