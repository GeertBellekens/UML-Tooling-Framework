using System.Collections.Generic;
using UML = TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.UML.CommonBehaviors.BasicBehaviors {

    //Provides a mechanism for precisely defining the behavior of an opaque expression. An opaque expression is defined by a
    //behavior restricted to return one result.
	public interface OpaqueExpression : UML.Classes.Kernel.OpaqueExpression {
        
        //Specifies the behavior of the opaque expression.
		 Behavior behavior{ get; set; }

        //Restricts an opaque expression to return exactly one return result. When the invocation of the opaque expression
        //completes, a single set of values is returned to its owner. This association is derived from the single return result
        //parameter of the associated behavior.
		 UML.Classes.Kernel.Parameter result{ get; set; }

	}

}