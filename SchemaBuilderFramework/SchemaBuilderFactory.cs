
using System;
using System.Collections.Generic;
using UML=TSF.UmlToolingFramework.UML;
using System.Linq;

namespace SchemaBuilderFramework
{
	/// <summary>
	/// Description of SchemaBuilderFactory.
	/// </summary>
	public abstract class SchemaBuilderFactory
	{
		private static Dictionary<UML.UMLModel, SchemaBuilderFactory> instances = new Dictionary<UML.UMLModel,SchemaBuilderFactory>();
	
	    private static void addFactory(UML.UMLModel model, SchemaBuilderFactory factory) 
	    {
		      if (!instances.ContainsKey(model)) 
			  {
			  instances.Add(model, factory);
			  }
	    }


	
	    /// returns the singleton instance of the factory
	    public static SchemaBuilderFactory getInstance(UML.UMLModel model) 
	    {
	    	SchemaBuilderFactory instance = null;
	    	instances.TryGetValue(model,out instance);
	    	return instance;
	    }
	    /// <summary>
	    /// returns the first instance of the factory.
	    /// To be used when only one factory exists
	    /// </summary>
	    /// <returns>the first (and only?) instance of the factory</returns>
	    public static SchemaBuilderFactory getInstance()
	    {
	    	if (instances.Count > 0)
	    	{
	    		return instances.Values.ElementAt(0);
	    	}else
	    	{
	    		return null;
	    	}
	    }
		
		public UML.UMLModel model {get;set;}
		protected SchemaBuilderFactory(UML.UMLModel model)
		{
			this.model = model;
			addFactory(model, this);
		}
		public abstract Schema createSchema(object objectToWrap, SchemaSettings settings);
		public abstract SchemaElement createSchemaElement(Schema owner,object objectToWrap);
		public abstract SchemaProperty createSchemaProperty(SchemaElement owner,object objectToWrap);
		public abstract SchemaLiteral createSchemaLiteral(SchemaElement owner,object objectToWrap);
		public abstract SchemaAssociation createSchemaAssociation(SchemaElement owner,object objectToWrap);
	}
}
