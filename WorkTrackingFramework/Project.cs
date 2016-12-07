
using System;
using System.Collections.Generic;
using UML=TSF.UmlToolingFramework.UML;
using System.Linq;

namespace WorkTrackingFramework
{
	/// <summary>
	/// Description of Project.
	/// </summary>
	public interface Project
	{
		List<Workitem> workitems {get;set;}
		string name {get;set;}
		List<Workitem> getOwnedWorkitems(UML.Classes.Kernel.Package ownerPackage, bool recursive);
	}
}
