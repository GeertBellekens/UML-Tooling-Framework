
using System;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of PrimaryKeyTransformer.
	/// </summary>
	public interface PrimaryKeyTransformer
	{
		PrimaryKey primaryKey {get;set;}
		void resetName();
		/// <summary>
		/// save the changes from the transformer to the existing database
		/// </summary>
		void save();
	}
}
