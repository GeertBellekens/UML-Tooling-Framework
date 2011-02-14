using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;


namespace TSF.UmlToolingFramework.UML.Interactions.Fragments
{

    //A lifeline represents an individual participant in the Interaction. While Parts and StructuralFeatures may have multiplicity
    //greater than 1, Lifelines represent only one interacting entity.
    //Lifeline is a specialization of NamedElement.
    //If the referenced ConnectableElement is multivalued (i.e, has a multiplicity > 1), then the Lifeline may have an
    //expression (the ‘selector’) that specifies which particular part is represented by this Lifeline. If the selector is omitted, this
    //means that an arbitrary representative of the multivalued ConnectableElement is chosen.
    public interface Lifeline : UML.Classes.Kernel.NamedElement
    {

        //If the referenced ConnectableElement is multivalued, then this specifies the specific individual part within that set.
        UML.Classes.Kernel.ValueSpecification selector { get; set; }

        //References the Interaction enclosing this Lifeline.
        Interaction interaction { get; set; }

        //References the ConnectableElement within the classifier that contains the enclosing interaction.
        UML.CompositeStructures.InternalStructures.ConnectableElement represents { get; set; }

        //References the Interaction that represents the decomposition.
        UML.Interactions.Fragments.PartDecomposition decomposedAs { get; set; }

        //References the InteractionFragments in which this Lifeline takes part
        InteractionFragment coveredBy { get; set; }

    }

}