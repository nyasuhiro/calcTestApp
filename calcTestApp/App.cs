using System;
using Xamarin.Forms;
namespace calcTestApp
{
	public class App : Application
	{
		public App()
		{
			// MyContentPageを継承したクラスを生成してMainPageとする。
			// MainPage = new MyContentPage();

			MainPage = new NavigationPage(new MainPage())
			{
				BarBackgroundColor = Color.FromRgba(0.2, 0.6, 0.86, 1),
				BarTextColor = Color.White
			};
		}
	}
}

