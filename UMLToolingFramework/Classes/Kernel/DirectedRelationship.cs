namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  DirectedRelationship : Relationship {
		Element target { get; set; }
    Element source { get; set; }
	}
}
