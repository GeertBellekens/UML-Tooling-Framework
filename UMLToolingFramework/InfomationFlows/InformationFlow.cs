using System.Collections.Generic;
using System;

namespace TSF.UmlToolingFramework.UML.InfomationFlows
{
	/// <summary>
	/// Description of InformationFlow.
	/// </summary>
	public interface InformationFlow: UML.Classes.Kernel.DirectedRelationship, UML.Classes.Kernel.PackageableElement
	{
		HashSet<UML.Classes.Kernel.Classifier> conveyed {get;set;}
		HashSet<UML.Classes.Kernel.Relationship> realizations {get;set;}
	}
}
