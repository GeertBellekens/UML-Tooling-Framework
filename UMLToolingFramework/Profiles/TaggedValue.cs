
namespace TSF.UmlToolingFramework.UML.Profiles 
{
	/// <summary>
	/// Description of TaggedValue.
	/// </summary>
	public interface TaggedValue:UML.Extended.UMLItem
	{
		new string name { get; set; }
		object tagValue {get;set;}
		string comment {get;set;}
	}
}
