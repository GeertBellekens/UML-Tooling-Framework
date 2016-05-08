
using System;

namespace TSF.UmlToolingFramework.UML.Classes.AssociationClasses
{
	/// <summary>
	/// A model element that has both Association and Class properties. An AssociationClass can be seen as an Association that
	/// also has Class properties, or as a Class that also has Association properties. It not only connects a set of Classifiers but
	/// also defines a set of Features that belong to the Association itself and not to any of the associated Classifiers.
	/// </summary>
	public interface AssociationClass : TSF.UmlToolingFramework.UML.Classes.Kernel.Class, TSF.UmlToolingFramework.UML.Classes.Kernel.Association
	{
		
	}
}
