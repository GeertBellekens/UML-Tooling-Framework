using System.Collections.Generic;
using System.Linq;
using System;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of View.
	/// </summary>
	public interface View:DatabaseItem
	{
		Database databaseOwner {get;set;}
		string definition {get;set;}
		string viewOwner {get;set;}
	}
}
