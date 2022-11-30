namespace CalculatorApp.Common
{
	public class MathPhrase
	{
		public MathPhrase(double leftNumber)
		{
			LeftNumber = leftNumber;
		}
		public MathPhrase()
		{

		}

		public double LeftNumber { get; set; }
		public IOperator Operator { get; set; }
		public MathPhrase RightPhrase { get; set; }
		public double CalculatePhrase()
		{
			if (RightPhrase==null)
			{
				return LeftNumber;
			}
			return Operator.Calculate(LeftNumber, RightPhrase.CalculatePhrase());
		}
	}
}
