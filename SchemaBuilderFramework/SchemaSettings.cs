using System;
using System.Collections.Generic;
using TSF.UmlToolingFramework.UML.Classes.Kernel;
using UML = TSF.UmlToolingFramework.UML;

namespace SchemaBuilderFramework
{
    /// <summary>
    /// Description of SchemaSettings.
    /// </summary>
    public interface SchemaSettings
    {
        /// <summary>
        /// List of stereotypes for which the "ignore inheritance selection" works inverse
        /// </summary>
        List<string> inheritancExceptionStereotypes { get; set; }
        /// <summary>
        /// list of stereotypes of elements to ignore when updating a subset model
        /// </summary>
        List<string> ignoredStereotypes { get; set; }
        /// <summary>
        /// list of tagged value names to ignore when updating tagged values
        /// </summary>
        List<string> ignoredTaggedValues { get; set; }
        /// <summary>
        /// list of constraint types to ignore when updating constraints
        /// </summary>
        List<string> ignoredConstraintTypes { get; set; }
        /// <summary>
        /// indicates whether we need to copy the generalizations for classes
        /// </summary>
        bool copyExternalGeneralizations { get; set; }
        /// <summary>
        /// ignores wether or not the generalization is selected in the profile
        /// </summary>
        bool copyAllGeneralizations { get; set; }
        /// <summary>
        /// indicates if we need to copy the datatypes to the subset
        /// </summary>
        bool copyDataTypes { get; set; }
        /// <summary>
        /// indicates if we need to limit the datatypes to copy to only the given subset
        /// </summary>
        bool limitDataTypes { get; set; }
        /// <summary>
        /// the list of datatypes to copy
        /// </summary>
        List<string> dataTypesToCopy { get; set; }
        /// <summary>
        /// indicates whether we need to copy the generalizations for datatypes
        /// </summary>
        bool copyDataTypeGeneralizations { get; set; }
        /// <summary>
        /// the name of the tagged value to trace attributes to their model source
        /// </summary>
        string sourceAttributeTagName { get; set; }
        /// <summary>
        /// the name of the tagged value to trace associations to their model source
        /// </summary>		
        string sourceAssociationTagName { get; set; }
        /// <summary>
        /// indicates whether the generalizations should be copied to the subset if the parent element is in the subset as well.
        /// </summary>
        bool redirectGeneralizationsToSubset { get; set; }
        /// <summary>
        /// indicates whether the notes in the subset elements should be prefixed
        /// </summary>
        bool prefixNotes { get; set; }
        /// <summary>
        /// the prefix to use when prefixing the notes
        /// </summary>
        string prefixNotesText { get; set; }
        /// <summary>
        /// the output name to use
        /// </summary>
        string outputName { get; set; }
        /// <summary>
        /// delete subset elements that are not used?
        /// </summary>
        bool deleteUnusedSchemaElements { get; set; }
        /// <summary>
        /// base the subset on package structure only and not by following the relations of a message element
        /// </summary>
        bool usePackageSchemasOnly { get; set; }
        /// <summary>
        /// list of types or stereotypes that should not be added on diagrams
        /// </summary>
        List<string> hiddenElementTypes { get; set; }
        /// <summary>
        /// do not create attribute dependencies
        /// </summary>
        bool dontCreateAttributeDependencies { get; set; }
        /// <summary>
        /// orer the associations alphabetically
        /// </summary>
        bool orderAssociationsAlphabetically { get; set; }
        /// <summary>
        /// associations and attributes are ordered alphabetically amongst each other
        /// </summary>
        bool orderAssociationsAmongstAttributes { get; set; }
        /// <summary>
        /// use tagged value instead of trace to link elements of subsets to their source element
        /// </summary>
        bool tvInsteadOfTrace { get; set; }
        /// <summary>
        /// name of the tagged value to use instead of the trace
        /// </summary>
        string elementTagName { get; set; }
        /// <summary>
        /// Indicates that the original attribute order will be kep. If false then all new attributes will be added to the end.
        /// </summary>
        bool keepOriginalAttributeOrder { get; set; }
        /// <summary>
        /// Indicates that the attribute order for all attributes in the subset will be set to 0
        /// </summary>
        bool setAttributeOrderZero { get; set; }
        /// <summary>
        /// Associations to an XmlChoice element will be ordered before any attributes
        /// </summary>
        bool orderXmlChoiceBeforeAttributes { get; set; }
        /// <summary>
        /// keeps the notes of the subset in sync with the notes of the source model
        /// </summary>
        bool keepNotesInSync { get; set; }
        /// <summary>
        /// name of the tag that will be used as the override position tag on attributes and associatons
        /// </summary>
        string customPositionTag { get; set; }
        /// <summary>
        /// tagged values that will be synchronized to the subset.
        /// To be used for refGUID tagged values that reference another part of the master model.
        /// In the subset model the GUID will be replaced by the derived equivalent in the subset model.
        /// If the equivalent doesn't exist, the tagged value will not be retained in the subset model.
        /// </summary>
        List<string> synchronizedTaggedValues { get; set; }
        /// <summary>
        /// if true it this will create elements with the same name for the redefined elements, but use the redefined name in the alias
        /// </summary>
        bool useAliasForRedefinedElements { get; set; }
        /// <summary>
        /// copy all operations to the subset class
        /// </summary>
        bool copyAllOperations { get; set; }
        /// <summary>
        /// name of the tagged value to be used to reference operations
        /// </summary>
        string sourceOperationTagName { get; set; }
        /// <summary>
        /// use the multiplicity to determine the value of the "use" tag. "required" if lowerbound = 1, "optional" if lowerbound = 0
        /// </summary>
        bool useMultiplicityForUseTagOnXsdAttributes { get; set; }
        /// <summary>
        /// Move elements to a recycle bin package instead of deleting
        /// </summary>
        bool useRecycleBin { get; set; }
        /// <summary>
        /// The name of the recycle bin package
        /// </summary>
	    string recycleBinName { get; set; }

        /// <summary>
        /// Determines if all generalizations have to be copied for this element, based on the property CopyAllGeneralizations, and the inheritanceExceptionStereotypes
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool copyAllGeneralizationsForElement(SchemaElement element);
    }
}
