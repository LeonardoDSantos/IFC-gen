/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcEllipse : IfcConic 
	{
		public IfcEllipse(Double semiAxis1,
				Boolean semiAxis1Specified,
				Double semiAxis2,
				Boolean semiAxis2Specified,
				IfcConicPosition position,
				IfcStyledItem styledByItem) : base(position,
				styledByItem)
		{
			this.semiAxis1Field = semiAxis1;
			this.semiAxis1SpecifiedField = semiAxis1Specified;
			this.semiAxis2Field = semiAxis2;
			this.semiAxis2SpecifiedField = semiAxis2Specified;
		}
	}
}