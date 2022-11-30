using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CalculatorApp.Common
{
	public class InMemoryOperatorContainer : IOperatorContainer
	{
		private readonly Dictionary<string, Type> _operators = new Dictionary<string, Type>();

		public InMemoryOperatorContainer()
		{
			var operatorTypes = Assembly.GetExecutingAssembly().GetTypes().Where(i => i.GetInterfaces().Contains(typeof(IOperator)) && i.GetCustomAttribute<OperatorTypeAttribute>() != null);
			foreach (var item in operatorTypes)
			{
				var attr = item.GetCustomAttribute<OperatorTypeAttribute>();
				_operators.Add(attr?.Type.ToString(), item);
			}
		}
		public IOperator GetOperator(OperatorType type)
		{
			return (IOperator)Activator.CreateInstance(_operators[type.ToString()]);
		}
	}
}