using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Diagrams {
  /// the representation of an element on a diagram
  public interface DiagramElement {
    UML.Classes.Kernel.Element element   { get; set; }
    int                        xPosition { get; set; }
    int                        yPosition { get; set; }
  }
}
