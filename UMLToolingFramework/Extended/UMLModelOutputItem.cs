
using System;
using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Extended
{
	/// <summary>
	/// Description of UMLModelOutputItem.
	/// </summary>
    public class UMLModelOutPutItem
    {
        public UMLModelOutPutItem(UMLItem outputElement, List<string> outputFields)
        {
            this.outputElement = outputElement;
            this.outputFields = outputFields;
        }
        public UMLItem outputElement { get; set; }
        public List<string> outputFields { get; set; }
    }
}
