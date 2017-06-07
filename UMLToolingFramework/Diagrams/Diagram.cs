using System.Collections.Generic;

using UML = TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Diagrams {
	public interface Diagram:UML.Extended.UMLItem {
        string                           name            { get; set; }
        HashSet<DiagramElement>          diagramElements { get; set; }
        List<UML.Classes.Kernel.Element> elements        { get; set; }
        UML.Classes.Kernel.Element owner {get;set;}
        
        int     height  { get; set; }
        int     width   { get; set; }
        string comment {get;set;}
  		/// <summary>
  		/// The elements that have this diagram as composite diagram
  		/// </summary>
        HashSet<UML.Classes.Kernel.Element> compositeElements {get;}

        /// <summary>
        /// gets the diagramElements for that contain an Element the given type
        /// </summary>
        /// <returns>a set of diagramElement of the given type</returns>
        HashSet<DiagramElement> getDiagramElements<T>() where T:UML.Classes.Kernel.Element;
        /// <summary>
        /// searches downward for the item with the given relative path
        /// This relative path includes the own name
        /// </summary>
        /// <param name="relativePath">list of names inlcuding the own name</param>
        /// <returns>the item matching the path</returns>
        UML.Extended.UMLItem getItemFromRelativePath(List<string> relativePath);
        /// <summary>
        /// saves the diagram
        /// </summary>
        void save();
        /// <summary>
        /// select the given item in the diagram
        /// </summary>
        /// <param name="itemToSelect">the item to select</param>
        void selectItem(UML.Extended.UMLItem itemToSelect);
		/// <summary>
        /// adds an element to the diagram to the given coördinates
		/// </summary>
		/// <param name="element">the element to add</param>
		/// <param name="x">the x position</param>
		/// <param name="y">th y position</param>
		/// <param name="newHeight">the height of the new diagramElement</param>
		/// <param name="newWidth">the width of the new diagramElement</param>
        /// <returns>the new diagramElement</returns>
        DiagramElement addToDiagram(UML.Classes.Kernel.Element element,int x = 0,int y = 0, int newHeight=0, int newWidth=0);
		/// <summary>
		/// add the given diagram to this diagram
		/// </summary>
		/// <param name="diagram">the diagram to add</param>
		/// <param name="x">the x position</param>
		/// <param name="y">th y position</param>
		/// <param name="newHeight">the height of the new diagramElement</param>
		/// <param name="newWidth">the width of the new diagramElement</param>
		/// <returns>the diagramElement representing the diagram</returns>
        DiagramElement addToDiagram(UML.Diagrams.Diagram diagram,int x = 0,int y = 0, int newHeight=0, int newWidth=0);
        /// <summary>
        /// Automaticaly layouts the diagram so it looks nice
        /// </summary>
        void autoLayout();
        /// <summary>
        /// indicates if the given element is shown on this diagram
        /// </summary>
        /// <param name="element">the element to look for</param>
        /// <returns>true if the given element is shown on this diagram, false otherwise</returns>
        bool contains(UML.Classes.Kernel.Element element);
        /// <summary>
        /// refreshes the diagram to show any new changes
        /// </summary>
        void reFresh();

        
  }
}
