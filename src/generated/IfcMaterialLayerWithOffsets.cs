/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMaterialLayerWithOffsets : IfcMaterialLayer 
	{
		public IfcMaterialLayerWithOffsets(IfcLayerSetDirectionEnum offsetDirection,
				Boolean offsetDirectionSpecified,
				Double[] offsetValues,
				IfcMaterial material,
				Double layerThickness,
				Boolean layerThicknessSpecified,
				IfcLogical isVentilated,
				Boolean isVentilatedSpecified,
				String name,
				String description,
				String category,
				Int64 priority,
				Boolean prioritySpecified,
				IfcMaterialDefinitionHasProperties hasProperties) : base(material,
				layerThickness,
				layerThicknessSpecified,
				isVentilated,
				isVentilatedSpecified,
				name,
				description,
				category,
				priority,
				prioritySpecified,
				hasProperties)
		{
			this.offsetDirectionField = offsetDirection;
			this.offsetDirectionSpecifiedField = offsetDirectionSpecified;
			this.offsetValuesField = offsetValues;
		}
	}
}