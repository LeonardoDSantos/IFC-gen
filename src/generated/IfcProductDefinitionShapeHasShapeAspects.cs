/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcProductDefinitionShapeHasShapeAspects : Object 
	{
		public IfcProductDefinitionShapeHasShapeAspects(IfcShapeAspect[] ifcShapeAspect,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize) : base()
		{
			this.ifcShapeAspectField = ifcShapeAspect;
			this.itemTypeField = itemType;
			this.cTypeField = cType;
			this.arraySizeField = arraySize;
		}
	}
}