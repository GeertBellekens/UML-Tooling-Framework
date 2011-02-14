using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.BasicBehaviors
{
    //Behavior is a specification of how its context classifier changes state over time. This specification may be either a
    //definition of possible behavior execution or emergent behavior, or a selective illustration of an interesting subset of
    //possible executions. The latter form is typically used for capturing examples, such as a trace of a particular execution.
    //
    //A classifier behavior is always a definition of behavior and not an illustration. It describes the sequence of state changes
    //an instance of a classifier may undergo in the course of its lifetime. Its precise semantics depends on the kind of classifier.
    //For example, the classifier behavior of a collaboration represents emergent behavior of all the parts, whereas the classifier
    //behavior of a class is just the behavior of instances of the class separated from the behaviors of any of its parts.
    //
    //When a behavior is associated as the method of a behavioral feature, it defines the implementation of that feature (i.e., the
    //computation that generates the effects of the behavioral feature).
    //
    //As a classifier, a behavior can be specialized. Instantiating a behavior is referred to as “invoking” the behavior, an
    //instantiated behavior is also called a behavior “execution.” A behavior may be invoked directly or its invocation may be
    //the result of invoking the behavioral feature that specifies this behavior. A behavior can also be instantiated as an object
    //in virtue of it being a class.
    //
    //The specification of a behavior can take a number of forms, as described in the subclasses of Behavior. Behavior is an
    //abstract metaclass factoring out the commonalities of these different specification mechanisms.
    //
    //When a behavior is invoked, its execution receives a set of input values that are used to affect the course of execution,
    //and as a result of its execution it produces a set of output values that are returned, as specified by its parameters. The
    //observable effects of a behavior execution may include changes of values of various objects involved in the execution, the
    //creation and destruction of objects, generation of communications between objects, as well as an explicit set of output
    //values.
	public interface  Behavior : UML.Classes.Kernel.Class {

        //Tells whether the behavior can be invoked while it is still executing from a previous invocation. Default value is
        //true.
		 bool isReentrant{ get; set; }

        //Designates a behavioral feature that the behavior implements. The behavioral feature must be owned by the
        //classifier that owns the behavior or be inherited by it. The parameters of the behavioral feature and the
        //implementing behavior must match. A behavior does not need to have a specification, in which case it either is the
        //classifier behavior of a BehavioredClassifier or it is a behavior that can only invoked by another behavior of the
        //classifier.
         BehavioralFeature specification{ get; set; }

        //The classifier that is the context for the execution of the behavior. If the behavior is owned by a BehavioredClassifier,
        //that classifier is the context{ get; set; } otherwise, the context is the first BehavioredClassifier reached by following the chain of
        //owner relationships. For example, following this algorithm, the context of an entry action in a state machine is the
        //classifier that owns the state machine. The features of the context classifier as well as the elements visible to the
        //context classifier are visible to the behavior. (Subsets RedefinableElement::redefinitionContext)
		 BehavioredClassifier context{ get; set; }

        //References a list of parameters to the behavior that describes the order and type of arguments that can be given
        //when the behavior is invoked and of the values that will be returned when the behavior completes its execution.
        //(Subsets Namespace::ownedMember)
         HashSet<UML.Classes.Kernel.Parameter> ownedParameters{ get; set; }

        //References a behavior that this behavior redefines. A subtype of Behavior may redefine any other subtype of
        //Behavior. If the behavior implements a behavioral feature, it replaces the redefined behavior. If the behavior is a
        //classifier behavior, it extends the redefined behavior. (Subsets RedefineableElement::redefinedElement)
		 Behavior redefinedBehavior{ get; set; }

        // An optional set of Constraints specifying what must be fulfilled when the behavior is invoked. (Subsets
        //Namespace::ownedRule)
         HashSet<UML.Classes.Kernel.Constraint> preconditions{ get; set; }

        //An optional set of Constraints specifying what is fulfilled after the execution of the behavior is completed, if its
        //precondition was fulfilled before its invocation. (Subsets Namespace::ownedRule)
		 HashSet<UML.Classes.Kernel.Constraint> postconditions{ get; set; }

	}
}