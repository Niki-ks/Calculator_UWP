using Windows.UI.Xaml.Controls;

namespace Calculator_UWP.View.Controls
{
	public sealed partial class IOTextBox : UserControl
	{
		public IOTextBox()
		{
			this.InitializeComponent();
		}

		public void SetTextBox(char value)
		{
			RootTextBox.Text += value;
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
