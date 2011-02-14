using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Actions.BasicActions {

    //A value pin is an input pin that provides a value by evaluating a value specification.
    public interface ValuePin : InputPin {

        //Value that the pin will provide.
		UML.Classes.Kernel.ValueSpecification value{ get; set; }
	}
}