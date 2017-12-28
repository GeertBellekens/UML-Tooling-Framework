using System.Collections.Generic;
using TSF.UmlToolingFramework;
using TSF.UmlToolingFramework.UML.Classes.Kernel;

namespace TSF.UmlToolingFramework.UML.Extended {
  public interface UMLModel {
    /// the currently selected element
    UML.Classes.Kernel.Element selectedElement { get;set; }
    /// the factory for all UML elements for this type of model
    UMLFactory factory { get; }
    UML.Diagrams.Diagram currentDiagram { get; set; }
    void saveElement(UML.Classes.Kernel.Element element);
    void saveDiagram(UML.Diagrams.Diagram diagram);
    /// <summary>
    /// reload the open diagrams
    /// </summary>
    void reloadDiagrams();
    
    /// <summary>
    /// finds the items (if any) with the given fully qualified name (. separated)
    /// </summary>
    /// <param name="FQN">the "." separated fully qualified name</param>
    /// <returns>the element with the given FQN</returns>
    UMLItem getItemFromFQN(string FQN);
    HashSet<UML.Classes.Kernel.Package> rootPackages {get;}
    UML.Extended.UMLItem selectedItem{get;set;}
    /// <summary>
    /// lets the user select a package and return that
    /// The user should be shown a dialog that allows him to select a package from the model
    /// </summary>
    /// <returns>the package selected by the user</returns>
    UML.Classes.Kernel.Package getUserSelectedPackage();
    /// <summary>
    /// Lets the user select an element from the model and return that
    /// </summary>
    /// <param name="allowedTypes">the subtypes of UML.Classes.Kernel.Element that should be used as a filter</param>
    /// <returns>the selected element</returns>
    UML.Classes.Kernel.Element getUserSelectedElement(List<string> allowedTypes);
	/// <summary>
	/// selects the root package for the currently selected item
	/// </summary>
	/// <returns>the root package for the currently selecte item</returns>
	UML.Classes.Kernel.Package getCurrentRootPackage();
	/// <summary>
	/// returns the item corresponding to the given Unique ID
	/// </summary>
	/// <param name="guidString">the unique id of the item</param>
	/// <returns>the item corresponding to the unique ID</returns>
	UML.Extended.UMLItem getItemFromGUID(string guidString);
  }
}
