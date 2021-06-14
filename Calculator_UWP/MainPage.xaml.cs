using Calculator_UWP.View.Controls;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Calculator_UWP
{
    public sealed partial class MainPage : Page
    {
        //https://www.codeproject.com/Articles/11164/Math-Parser

        public MainPage()
        {
            InitializeComponent();

			key.KeyTap += _Keyboard_KeyTap;
		}

		private void _Keyboard_KeyTap(char key)
		{
			ioTB.SetTextBox(key);
		}

		private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			//var hight = e.PreviousSize.Height;
			//double minHight = hight / 4;
			//double maxHight = hight / 4 * 3;

			//I1.Height = new GridLength(minHight);
			//I2.Height = new GridLength(maxHight);
		}

		private void Grid_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
		{

		}
	}
}
