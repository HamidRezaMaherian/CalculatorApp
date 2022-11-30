namespace CalculatorApp.Common
{
	public interface IOperatorContainer
	{
		public IOperator GetOperator(OperatorType type);
	}
}