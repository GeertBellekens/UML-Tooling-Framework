
using System;
using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of DataBaseFactory.
	/// </summary>
	public interface DataBaseFactory
	{
		List<BaseDataType> baseDataTypes {get;}
		UML.Extended.UMLFactory modelFactory {get;}
		string databaseName {get;}
	}
}
