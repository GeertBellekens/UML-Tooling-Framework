using System.Collections.Generic;
using System;

namespace TSF.UmlToolingFramework.UML.InfomationFlows
{
	/// <summary>
	/// Description of InformationFlow.
	/// </summary>
	public interface InformationItem: UML.Classes.Kernel.Classifier
	{
		HashSet<UML.Classes.Kernel.Classifier> represented {get;set;}
	}
}
