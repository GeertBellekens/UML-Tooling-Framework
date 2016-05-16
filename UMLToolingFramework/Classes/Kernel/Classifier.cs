using System.Collections.Generic;

using TSF.UmlToolingFramework;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface  Classifier : RedefinableElement, Type, Namespace {
		bool isAbstract{ get; set; }

		HashSet<Generalization> generalizations { get; set; }
    HashSet<Property>       attributes      { get; set; }
    HashSet<Feature>        features        { get; set; }
    HashSet<UML.Classes.Dependencies.Substitution> substitutions { get; set; }
    /// <summary>
    /// convenience method to return the Information flows that convey this classifier
    /// </summary>
    /// <returns>all InformationFlows that convey this classifier</returns>
    HashSet<UML.InfomationFlows.InformationFlow> getConveyingFlows();
	}
}
