using System.Collections.Generic;

using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Diagrams {
  public interface SequenceDiagram:Diagram {

  	
	List<UML.Classes.Kernel.Operation> getCalledOperations();
  }
}
