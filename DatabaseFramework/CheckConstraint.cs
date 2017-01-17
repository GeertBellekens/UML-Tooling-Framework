using System.Collections.Generic;
using System.Linq;
using System;


namespace DatabaseFramework
{
	/// <summary>
	/// Description of CheckConstraint.
	/// </summary>
	public interface CheckConstraint:Constraint
	{
		string rule {get;set;}
	}
}
