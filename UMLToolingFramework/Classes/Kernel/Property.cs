using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Property : StructuralFeature {
		bool               isDerived           { get; set; }
		bool               isDerivedUnion      { get; set; }
   		bool               isComposite         { get; set; }
		string             _default            { get; set; }
		AggregationKind    aggregation         { get; set; }
		ValueSpecification defaultValue        { get; set; }
		HashSet<Property>  redefinedProperties { get; set; }
		HashSet<Property>  subsettedProperties { get; set; }
		Property           opposite            { get; set; }
		Classifier         classifier          { get; set; }
    	Class              _class              { get; set; }
		Association        owningAssociation   { get; set; }
		Association        association         { get; set; }
    	DataType           datatype            { get; set; }

    /// The query isNavigable() indicates whether it is possible to navigate 
    /// across the property.
    /// Property::isNavigable() : Boolean
    /// isNavigable = not classifier->isEmpty() or 
    /// association.owningAssociation.navigableOwnedEnd->includes(self)
    bool getIsNavigable();
        
    /// TODO: remove this non UML property once the real isNavigable() is
    /// implementable
    bool isNavigable { get; set; }
	}
}
