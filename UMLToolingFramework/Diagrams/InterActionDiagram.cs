/*
 * Created by SharpDevelop.
 * User: wij
 * Date: 4/07/2013
 * Time: 5:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Diagrams 
{
	/// <summary>
	/// Description of InterActionDiagram.
	/// </summary>
	public interface InterActionDiagram : BehaviorDiagram
	{
		List<UML.Classes.Kernel.Operation> getCalledOperations();
		
	}
}
