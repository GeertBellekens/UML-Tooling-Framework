using System.Collections.Generic;

using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Interfaces {
  /// An interface is a kind of classifier that represents a declaration of a 
  /// set of coherent public features and obligations. An interface specifies
  /// a contract; any instance of a classifier that realizes the interface
  /// must fulfill that contract. The obligations that may be associated with
  /// an interface are in the form of various kinds of constraints (such as
  /// pre- and postconditions) or protocol specifications, which may impose
  /// ordering restrictions on interactions through the interface.
  /// Since interfaces are declarations, they are not instantiable. Instead,
  /// an interface specification is implemented by an instance of an
  /// instantiable classifier, which means that the instantiable classifier
  /// presents a public facade that conforms to the interface specification.
  /// Note that a given classifier may implement more than one interface and
  /// that an interface may be implemented by a number of different
  /// classifiers (see “InterfaceRealization (from Interfaces)” on page 89).
	public interface Interface :  UML.Classes.Kernel.Classifier {
    HashSet<UML.Classes.Kernel.Classifier> nestedClassifiers { get; set; }
    List<InterfaceRealization>             InterfaceRealizations { get; set; }
    HashSet<UML.Classes.Kernel.Operation>  ownedOperations { get; set; }
    List<Interface>                        redefinedInterface { get; set; }
    HashSet<UML.Classes.Kernel.Property>   ownedAttributes { get; set; }
	}
}
