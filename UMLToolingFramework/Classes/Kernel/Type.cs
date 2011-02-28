using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UML=TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Type : PackageableElement {
		
		HashSet<UML.Classes.Kernel.Property> getUsingAttributes();
		HashSet<UML.Classes.Kernel.Parameter> getUsingOperations();
	}
	
}
