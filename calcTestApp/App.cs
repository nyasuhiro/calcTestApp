using System;
using Xamarin.Forms;
namespace calcTestApp
{
	public class App : Application
	{
		public App()
		{
			// MyContentPageを継承したクラスを生成してMainPageとする。
			MainPage = new MyContentPage();
		}
	}
}

