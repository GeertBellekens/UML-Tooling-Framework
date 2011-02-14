using System.Collections.Generic;

using UML = TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Operation : BehavioralFeature {
		bool                isQuery             { get; set; }
		bool                isOrdered           { get; set; }
		bool                isUnique            { get; set; }
		int                 lower               { get; set; }
		UnlimitedNatural    upper               { get; set; }
        Type                type                { get; set; }
        HashSet<Operation>  redefinedOperations { get; set; }
        Constraint          bodyCondition       { get; set; }
        HashSet<Constraint> postcondition       { get; set; }
        HashSet<Constraint> precondition        { get; set; }

        /// (From Interface)
        /// The Interface that owns this Operation. (Subsets
        /// RedefinableElement::redefinitionContext,
        /// NamedElement::namespace and Feature::featuringClassifier)
        UML.Classes.Interfaces.Interface _interface { get; set; }

        /// isAbstract should be a derived attribute.
        /// An operation is abstract when is doesn't have an implementation
        /// This property is not standard UML but added for convenience reasons
        bool isAbstract { get; set; }

        // NON STANDARD UML
        // convenience method to get all messages that call this operation
        HashSet<UML.Interactions.BasicInteractions.Message> getCallingMessages();
        }
}
