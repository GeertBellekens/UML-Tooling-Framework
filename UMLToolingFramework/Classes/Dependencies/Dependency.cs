using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Dependencies {
  /// A dependency is a relationship that signifies that a single or a set 
  /// of model elements requires other model elements for their 
  /// specification or implementation. This means that the complete
  /// semantics of the depending elements is either semantically or
  /// structurally dependent on the definition of the supplier element(s).
  ///
  /// A dependency signifies a supplier/client relationship between model
  /// elements where the modification of the supplier may impact the client 
  /// model elements. A dependency implies the semantics of the client is
  /// not complete without the supplier. The presence of dependency
  /// relationships in a model does not have any runtime semantics
  /// implications, it is all given in terms of the model-elements that
  /// participate in the relationship, not in terms of their instances.
	public interface Dependency : UML.Classes.Kernel.DirectedRelationship, 
	                              UML.Classes.Kernel.PackageableElement 
	{
    /// The element(s) dependent on the supplier element(s). In some cases
    /// (such as a Trace Abstraction) the assignment of
    /// direction (that is, the designation of the client element) is at the
    /// discretion of the modeler, and is a stipulation. Subsets
    /// DirectedRelationship::source.
    UML.Classes.Kernel.NamedElement client { get; set; }
    /// The element(s) independent of the client element(s), in the same
    /// respect and the same dependency relationship. In some directed
    /// dependency relationships (such as Refinement Abstractions), a common
    /// convention in the domain of class-based OO software is to put the more
    /// abstract element in this role. Despite this convention, users of UML
    /// may stipulate a sense of dependency suitable for their domain, which
    /// makes a more abstract element dependent on that which is more
    /// specific. Subsets DirectedRelationship::target.
    UML.Classes.Kernel.NamedElement supplier { get; set; }
	}
}
