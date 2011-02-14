using System.Collections.Generic;

using UML = TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Diagrams {
  public interface Diagram {
        string                           name            { get; set; }
        HashSet<DiagramElement>          diagramElements { get; set; }
        List<UML.Classes.Kernel.Element> elements        { get; set; }
        UML.Classes.Kernel.Element       owner           { get; set; }
        
        int     height  { get; set; }
        int     width   { get; set; }
        string  comment { get; set; }

        /// gets the diagramElements for that contain an Element the given type
        HashSet<DiagramElement> getDiagramElements<T>() 
          where T:UML.Classes.Kernel.Element;
       
        void save();
        void open();
  }
}
