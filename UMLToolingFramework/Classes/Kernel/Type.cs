using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UML=TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Type : PackageableElement {
		
		/// <summary>
		/// Returns the TypedElements that use this Type as their type.
		/// Results are limited to the given subtype of TypedElement
		/// </summary>
		/// <returns>The TypedElements that use this Type as their type</returns>
		HashSet<T> getDependentTypedElements<T>() where T:UML.Classes.Kernel.TypedElement;
	}
	
}
