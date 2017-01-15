
using System;
using System.Collections.Generic;

namespace DatabaseFramework
{
	/// <summary>
	/// Description of Index.
	/// </summary>
	public interface Index : Constraint
	{
    	bool isUnique    { get; set; }
    	bool isClustered { get; set; }
	}
}
