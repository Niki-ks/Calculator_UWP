using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Reflection;

using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CSharp;

using Windows.UI.Xaml.Controls;
namespace Calculator_UWP.View.Controls
{
	public sealed partial class Keyboard : UserControl
	{
		public delegate void KeyTapEventHandler(char key);
		public event KeyTapEventHandler KeyTap;

		enum AriphmeticKeys
		{
			Division,
			Multiplication,
			Subtraction,
			Addition
		}

		public Keyboard()
		{
			InitializeComponent();
		}

		private void Key_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			var obj = sender as ContentPresenter;
			if (obj.Tag != null)
			{
				KeyTap?.Invoke(Convert.ToChar(obj.Tag));
			}
			else
			{
				KeyTap?.Invoke(Convert.ToChar(obj.Content));
			}
			//KeyTap.Invoke(())

			//var qwe = sender as ContentPresenter;
			//string examle = "(-5+5)*3,3455^4/1";

			//var p = new Parser();
			//if(p.Evaluate(examle))
			//{
			//	double weeeee = p.Result;
			//}
			//else
			//{
			//	// error
			//}
		}
	}
}
