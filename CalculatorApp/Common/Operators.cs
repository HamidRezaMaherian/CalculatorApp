using System.ComponentModel.DataAnnotations;

namespace CalculatorApp.Common
{
	[OperatorType(OperatorType.Addition)]
	public class AdditionOperator : IOperator
	{
		public double Calculate(double leftNum, double rightNum)
		{
			return leftNum + rightNum;
		}

	}
	[OperatorType(OperatorType.Division)]
	public class DivisionOperator : IOperator
	{
		public double Calculate(double leftNum, double rightNum)
		{
			return leftNum / rightNum;
		}
	}
	[OperatorType(OperatorType.Multiplication)]
	public class MultiplicantionOperator : IOperator
	{
		public double Calculate(double leftNum, double rightNum)
		{
			return leftNum * rightNum;
		}
	}
	[OperatorType(OperatorType.Substraction)]
	public class SubstractionOperator : IOperator
	{
		public double Calculate(double leftNum, double rightNum)
		{
			return leftNum - rightNum;
		}
	}
}