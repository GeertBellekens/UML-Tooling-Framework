
using System;
using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Extended
{
	/// <summary>
	/// Description of UMLModelOutput.
	/// </summary>
	public interface UMLModelOutput
	{
        List<UMLModelOutPutItem> output { get; set; }
        List<string> fields {get;set;}
        string name { get; set; }
        void show();
    }
	
}
