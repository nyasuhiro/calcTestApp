using System;
using Xamarin.Forms;
namespace calcTestApp
{
	class MainPage : ContentPage
	{
		public MainPage()
		{
			Title = "MainPage"; // ページのタイトル

			// ボタンを生成
			var button1 = new Button { Text = "NextPageへ移動" };
			// ボタンクリック時の処理
			button1.Clicked += async (s, a) =>
			{
				// ページを遷移する
				await Navigation.PushAsync(new NextPage());
			};

			Content = button1;
		}
	}
}
