
using System;

namespace DatabaseFramework.Transformation
{
	/// <summary>
	/// Description of DatabaseItemTransformer.
	/// </summary>
	public interface DatabaseItemTransformer
	{
		DatabaseItem databaseItem {get;}
		void rename(string newName);
		/// <summary>
		/// gets the transformer that has the given database item as new item
		/// </summary>
		/// <param name="item">the item to look for</param>
		/// <returns>the transformers that corresponds with the given item</returns>
		DatabaseItemTransformer getCorrespondingTransformer(DatabaseItem item);
	}
}
