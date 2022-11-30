using Microsoft.Maui.Controls;
using System;

namespace CalculatorApp.Common
{
	public class NumberButton : Button
	{
		public int Number { get; set; }
	}
	public class OperatorButton : Button
	{
		public OperatorType OperatorType { get; set; }
	}
}