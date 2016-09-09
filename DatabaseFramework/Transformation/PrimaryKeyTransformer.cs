
using System;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of PrimaryKeyTransformer.
	/// </summary>
	public interface PrimaryKeyTransformer:DatabaseItemTransformer
	{
		PrimaryKey primaryKey {get;set;}
		void resetName();

	}
}
