using CalculatorApp.Common;
using Microsoft.Maui.Controls;
using System;

namespace CalculatorApp;

public partial class MainPage : ContentPage
{
	private readonly IOperatorContainer _operatorContainer;
	private MathPhrase _mathPhrase;
	private MathPhrase _currentPhrase;
	private string _number;
	public MainPage(IOperatorContainer operatorContainer)
	{
		_mathPhrase = new MathPhrase();
		_currentPhrase = _mathPhrase;
		_operatorContainer = operatorContainer;
		InitializeComponent();
	}

	private void BtnNumber_Clicked(object sender, EventArgs e)
	{
		ArgumentNullException.ThrowIfNull(sender);
		NumberButton btn = sender as NumberButton;
		_number += btn?.Number.ToString() ?? ".";
		mathExpression.Text += btn?.Number.ToString() ?? ".";
		_currentPhrase.LeftNumber = Convert.ToDouble(_number);
		expressionResult.Text = (_mathPhrase?.CalculatePhrase() ?? btn?.Number).ToString();
	}
	private void BtnOperator_Clicked(object sender, EventArgs e)
	{
		ArgumentNullException.ThrowIfNull(sender);
		OperatorButton btn = sender as OperatorButton;

		_number = "";
		mathExpression.Text += btn?.Text;

		_currentPhrase.Operator = _operatorContainer.GetOperator(btn?.OperatorType ?? OperatorType.Equals);
		_currentPhrase.RightPhrase = new MathPhrase();
		_currentPhrase = _currentPhrase.RightPhrase;
	}
	private void BtnClear_Clicked(object sender, EventArgs e)
	{
		_mathPhrase = new MathPhrase();
		_currentPhrase = _mathPhrase;
		_number = "";
		mathExpression.Text = "";
		expressionResult.Text = "";
	}
	private void BtnResult_Clicked(object sender, EventArgs e)
	{
		mathExpression.Text = expressionResult.Text;
		expressionResult.Text = "";
		_mathPhrase = new MathPhrase(Convert.ToDouble(mathExpression.Text));
		_currentPhrase = _mathPhrase;
	}
}

