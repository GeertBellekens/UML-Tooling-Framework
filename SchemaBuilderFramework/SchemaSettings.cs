using System;
using System.Collections.Generic;
using TSF.UmlToolingFramework.UML.Classes.Kernel;
using UML=TSF.UmlToolingFramework.UML;

namespace SchemaBuilderFramework
{
	/// <summary>
	/// Description of SchemaSettings.
	/// </summary>
	public interface SchemaSettings
	{

		/// <summary>
		/// list of tagged value names to ignore when updating tagged values
		/// </summary>
		List<string> ignoredStereotypes{get;set;}
		/// <summary>
		/// list of stereotypes of elements to ignore when updating a subset model
		/// </summary>
		List<string> ignoredTaggedValues{get;set;}
		/// <summary>
		/// indicates if we need to copy the datatypes to the subset
		/// </summary>
		bool copyDataTypes {get;set;}
		/// <summary>
		/// indicates if we need to limit the datatypes to copy to only the given subset
		/// </summary>
		bool limitDataTypes {get;set;}
		/// <summary>
		/// the list of datatypes to copy
		/// </summary>
		List<string>dataTypesToCopy{get;set;}
		/// <summary>
		/// indicates whether we need to copy the generalizations for datatypes
		/// </summary>
		bool copyDataTypeGeneralizations {get;set;}
		
	}
}
