using System.Collections.Generic;

using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Diagrams {
  public interface CommunicationDiagram:Diagram {

  	
	List<UML.Classes.Kernel.Operation> getCalledOperations();
  }
}
