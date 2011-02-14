using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
  /// A comment is a textual annotation that can be attached to a set of
  /// elements.
	public interface Comment : Element {
    /// Specifies a string that is the comment.
    string body { get; set; }
    /// References the Element(s) being commented.
    HashSet<Element> annotatedElements { get; set; }
	}
}
