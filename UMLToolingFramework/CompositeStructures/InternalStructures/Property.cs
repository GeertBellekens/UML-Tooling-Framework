using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.CompositeStructures.InternalStructures {

    //A property represents a set of instances that are owned by a containing classifier instance.
    public interface Property : UML.Classes.Kernel.Property, ConnectableElement {
	}
}