using System.Collections.Generic;
using TSF.UmlToolingFramework;
using TSF.UmlToolingFramework.UML.Classes.Kernel;

namespace TSF.UmlToolingFramework.UML {
  public interface UMLModel {
    /// the currently selected element
    UML.Classes.Kernel.Element selectedElement { get;set; }
    /// the factory for all UML elements for this type of model
    UMLFactory factory { get; }
    UML.Diagrams.Diagram currentDiagram { get; set; }
    void saveElement(UML.Classes.Kernel.Element element);
    void saveDiagram(UML.Diagrams.Diagram diagram);
    
    /// <summary>
    /// finds the items (if any) with the given fully qualified name (. separated)
    /// </summary>
    /// <param name="FQN">the "." separated fully qualified name</param>
    /// <returns>the element with the given FQN</returns>
    UMLItem getItemFromFQN(string FQN);
    HashSet<UML.Classes.Kernel.Package> rootPackages {get;}
    UML.UMLItem selectedItem{get;set;}
    /// <summary>
    /// lets the user select a package and return that
    /// The user should be shown a dialog that allows him to select a package from the model
    /// </summary>
    /// <returns>the package selected by the user</returns>
    UML.Classes.Kernel.Package getUserSelectedPackage();
  }
}
