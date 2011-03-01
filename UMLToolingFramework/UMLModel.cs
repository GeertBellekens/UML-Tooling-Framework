using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML {
  public interface UMLModel {
    /// the currently selected element
    UML.Classes.Kernel.Element selectedElement { get; }
    /// the factory for all UML elements for this type of model
    UMLFactory factory { get; }
    UML.Diagrams.Diagram selectedDiagram { get; set; }
    void saveElement(UML.Classes.Kernel.Element element);
    void saveDiagram(UML.Diagrams.Diagram diagram);
    void selectElement(UML.Classes.Kernel.Element element);
  }
}
