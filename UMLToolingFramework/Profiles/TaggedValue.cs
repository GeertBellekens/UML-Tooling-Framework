
namespace TSF.UmlToolingFramework.UML.Profiles 
{
	/// <summary>
	/// Description of TaggedValue.
	/// </summary>
	public interface TaggedValue:UML.UMLItem
	{
		string name {get;set;}
		object tagValue {get;set;}
		UML.Classes.Kernel.Element owner {get;set;}
	}
}
