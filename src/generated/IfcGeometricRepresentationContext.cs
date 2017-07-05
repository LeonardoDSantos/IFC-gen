/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcGeometricRepresentationContext : IfcRepresentationContext 
	{
		public IfcGeometricRepresentationContext(IfcGeometricRepresentationContextWorldCoordinateSystem worldCoordinateSystem,
				IfcDirection trueNorth,
				IfcGeometricRepresentationContextHasSubContexts hasSubContexts,
				IfcCoordinateOperation hasCoordinateOperation,
				Int64 coordinateSpaceDimension,
				Boolean coordinateSpaceDimensionSpecified,
				Double precision,
				Boolean precisionSpecified,
				String contextIdentifier,
				String contextType) : base(contextIdentifier,
				contextType)
		{
			this.worldCoordinateSystemField = worldCoordinateSystem;
			this.trueNorthField = trueNorth;
			this.hasSubContextsField = hasSubContexts;
			this.hasCoordinateOperationField = hasCoordinateOperation;
			this.coordinateSpaceDimensionField = coordinateSpaceDimension;
			this.coordinateSpaceDimensionSpecifiedField = coordinateSpaceDimensionSpecified;
			this.precisionField = precision;
			this.precisionSpecifiedField = precisionSpecified;
		}
	}
}