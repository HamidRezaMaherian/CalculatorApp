using Microsoft.Maui.Controls;

namespace CalculatorApp;

public partial class App : Application
{
	public App(AppShell appShell)
	{
		InitializeComponent();

		MainPage = appShell;
	}
}
