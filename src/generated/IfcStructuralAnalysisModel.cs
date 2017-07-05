/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralAnalysisModel : IfcSystem 
	{
		public IfcStructuralAnalysisModel(IfcAxis2Placement3D orientationOf2DPlane,
				IfcStructuralAnalysisModelLoadedBy loadedBy,
				IfcStructuralAnalysisModelHasResults hasResults,
				IfcObjectPlacement sharedPlacement,
				IfcAnalysisModelTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcRelDefinesByObject isDeclaredBy,
				IfcRelDefinesByType isTypedBy,
				IfcObjectIsDefinedBy isDefinedBy,
				String objectType,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy) : base(isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.orientationOf2DPlaneField = orientationOf2DPlane;
			this.loadedByField = loadedBy;
			this.hasResultsField = hasResults;
			this.sharedPlacementField = sharedPlacement;
			this.predefinedTypeField = predefinedType;
			this.predefinedTypeSpecifiedField = predefinedTypeSpecified;
		}
	}
}