using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
namespace Calculator_UWP.View.Controls
{
	public sealed partial class CustomButton : UserControl, ICustomButton
	{
		public new string Content { get; set; }
		public AriphmeticNums AriphmeticNums { get; }
		public Numbers Numbers { get; }

		public CustomButton()
		{
			InitializeComponent();
		}


		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
