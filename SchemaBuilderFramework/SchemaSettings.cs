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
		/// indicates whether we need to copy the generalizations for classes
		/// </summary>
		bool copyGeneralizations {get;set;}
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
		/// <summary>
		/// the name of the tagged value to trace attributes to their model source
		/// </summary>
		string sourceAttributeTagName {get;set;}
		/// <summary>
		/// the name of the tagged value to trace associations to their model source
		/// </summary>		
		string sourceAssociationTagName {get;set;}
		/// <summary>
		/// indicates whether the generalizations should be copied to the subset if the parent element is in the subset as well.
		/// </summary>
		bool redirectGeneralizationsToSubset {get;set;}
		/// <summary>
		/// indicates whether the notes in the subset elements should be prefixed
		/// </summary>
		bool prefixNotes {get;set;}
		/// <summary>
		/// the prefix to use when prefixing the notes
		/// </summary>
		string prefixNotesText {get;set;}
		/// <summary>
		/// the output name to use
		/// </summary>
		string outputName {get;set;}
	}
}
