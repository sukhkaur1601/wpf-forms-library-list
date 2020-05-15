using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_App
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			float val1 = float.Parse(leftOperandTextBox.Text);
			float val2 = float.Parse(rightOperandTextBox.Text);
			float result = val1 + val2;
			resultAfterEvaluation.Text = result.ToString();
		}

		private void SubtractButton_Click(object sender, RoutedEventArgs e)
		{
			float val1 = float.Parse(leftOperandTextBox.Text);
			float val2 = float.Parse(rightOperandTextBox.Text);
			float result = val1 - val2;
			resultAfterEvaluation.Text = result.ToString();
		}

		private void MultiplyButton_Click(object sender, RoutedEventArgs e)
		{
			float val1 = float.Parse(leftOperandTextBox.Text);
			float val2 = float.Parse(rightOperandTextBox.Text);
			float result = val1 * val2;
			resultAfterEvaluation.Text = result.ToString();
		}

		private void DivideButton_Click(object sender, RoutedEventArgs e)
		{
			float val1 = float.Parse(leftOperandTextBox.Text);
			float val2 = float.Parse(rightOperandTextBox.Text);
			float result = val1 / val2;
			resultAfterEvaluation.Text = result.ToString();
		}

		private void PowerButton_Click(object sender, RoutedEventArgs e)
		{
			int val1 = int.Parse(leftOperandTextBox.Text);
			int val2 = int.Parse(rightOperandTextBox.Text);
			int result = 1;
			for(int i=0;i<val2;i++)
			{
				if(val2==0)
				{
					result = 1;
					break;
				}
				else
				{
					result *= val1;
				}
			}
			resultAfterEvaluation.Text = result.ToString();
		}
	}
}
