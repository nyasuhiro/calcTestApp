using System;
using Xamarin.Forms;
namespace calcTestApp
{
	class MyContentPage : ContentPage
	{
		public MyContentPage()
		{
			// iPhoneにおいて、ステータスバーとの重なりを防ぐためパディングを調整する。
			Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
			// ラベルを１つ生成
			var label1 = new Label
			{
				FontSize = 40,
				Text = "Developers.IO"
			};
			Content = label1;
		}
	}
}
