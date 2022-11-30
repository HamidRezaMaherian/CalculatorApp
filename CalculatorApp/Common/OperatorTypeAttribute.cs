using System;

namespace CalculatorApp.Common
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class OperatorTypeAttribute : Attribute
	{
		public OperatorType Type { get; set; }

		public OperatorTypeAttribute(OperatorType type)
		{
			Type = type;
		}
	}
}