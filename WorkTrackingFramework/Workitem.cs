
using System;
using System.Collections.Generic;

namespace WorkTrackingFramework
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public interface Workitem
	{
		string ID {get;set;}
		string type {get;set;}
		string title {get;set;}
		string state {get;set;}
		string description {get;set;}
		string assignedTo {get;set;}
		string area {get;set;}
		string iteration {get;set;}
	}
}