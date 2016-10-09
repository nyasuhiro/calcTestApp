using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace calcTestApp
{
	class MainPage : ContentPage
	{
		Label label;
		List<MyCalcNumberButton> numButtonList;

		public MainPage()
		{
			Title = "CalcTest"; // ページのタイトル
			numButtonList = new List<MyCalcNumberButton>();

			// 表示画面 
			label = new Label
			{
				Text = "hello world",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				BackgroundColor = Color.Lime
			};

			// ボタンを生成
			for (int i = 1; i <= 9; i++)
			{
				MyCalcNumberButton button = new MyCalcNumberButton();
				button.Text = i.ToString();
				button.HorizontalOptions = LayoutOptions.FillAndExpand;
				button.VerticalOptions = LayoutOptions.FillAndExpand;
				button.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
				button.Number = i;
				
				if (i % 2 == 0)
				{
					button.BackgroundColor = Color.Aqua;
				}
				else {
					button.BackgroundColor = Color.Yellow;
				}

				// ボタンクリック時の処理
				button.Clicked += delegate
				{
					label.Text = String.Format("{0}", button.Number);
				};
				numButtonList.Add(button);
			}

			Grid grid = new Grid
			{
				Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
			};

			for (int i = 0; i < numButtonList.Count; i++)
			{
				grid.Children.Add(numButtonList[i], i % 3, i / 3);
			}
	
			grid.Children.Add(label, 0, 3, 3, 4);

			Content = grid;
		}

	}
}
