/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPropertyReferenceValue : IfcSimpleProperty 
	{
		public IfcPropertyReferenceValue(IfcPropertyReferenceValuePropertyReference propertyReference,
				String usageName,
				String name,
				String description) : base(name,
				description)
		{
			this.propertyReferenceField = propertyReference;
			this.usageNameField = usageName;
		}
	}
}