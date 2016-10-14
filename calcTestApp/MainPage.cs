using System.Collections.Generic;
using Xamarin.Forms;

namespace calcTestApp
{
	class MainPage : ContentPage
	{
		Label label;
		List<MyCalcNumberButton> numButtonList;
		List<MyCalcOperButton> operButtonList;
		double firstNumber;
		double secondNumber;
		string oper;
		bool isSetSecondNum;

		public MainPage()
		{
			Title = "CalcTest"; // ページのタイトル
			numButtonList = new List<MyCalcNumberButton>();
			operButtonList = new List<MyCalcOperButton>();

			firstNumber = 0;
			secondNumber = 0;
			oper = "";
			isSetSecondNum = false;

			// 表示画面 
			label = new Label
			{
				Text = "出力フィールド",
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				BackgroundColor = Color.White,
				TextColor = Color.Black,
				FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
			};

			// 数字ボタンを作成
			createNumberButton();

			// 演算子ボタンを作成
			createOperButton();

			Grid grid = new Grid();

			// set 1-9 button
			for (int i = 1; i < numButtonList.Count; i++)
			{
				grid.Children.Add(numButtonList[i], (i - 1) % 3, (i - 1) / 3);
			}

			// set +, -, *, / button
			for (int i = 0; i < 4; i++)
			{
				grid.Children.Add(operButtonList[i], 3, i);
			}

			// set 0 button
			grid.Children.Add(numButtonList[0], 0, 3);

			// set clear button
			grid.Children.Add(operButtonList[5], 1, 3);

			// set equal button
			grid.Children.Add(operButtonList[4], 2, 3);

			StackLayout stack = new StackLayout
			{
				Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0)
			};

			stack.Children.Add(label);
			stack.Children.Add(grid);

			Content = stack;
		}



		void createNumberButton()
		{
			for (int i = 0; i <= 9; i++)
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
					if ("".Equals(oper))
					{
						firstNumber = firstNumber * 10 + button.Number;
						label.Text = string.Format("{0}", firstNumber);
					}
					else {
						isSetSecondNum = true;
						secondNumber = secondNumber * 10 + button.Number;
						label.Text = string.Format("{0}", firstNumber) + oper + string.Format("{0}", secondNumber);
					}

				};
				numButtonList.Add(button);
			}
		}



		void createOperButton()
		{
			for (int i = 0; i <= 5; i++)
			{
				MyCalcOperButton button = new MyCalcOperButton();
				button.HorizontalOptions = LayoutOptions.FillAndExpand;
				button.VerticalOptions = LayoutOptions.FillAndExpand;
				button.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
				string str = "";
				switch (i)
				{
					case 0:
						str = "+";
						button.Clicked += delegate
						{
							oper = button.Text;
							secondNumber = 0;
							isSetSecondNum = false;
							label.Text = string.Format("{0}", firstNumber) + oper;
						};
						break;
					case 1:
						str = "-";
						button.Clicked += delegate
						{
							oper = button.Text;
							secondNumber = 0;
							isSetSecondNum = false;
							label.Text = string.Format("{0}", firstNumber) + oper;
						};
						break;
					case 2:
						str = "×";
						button.Clicked += delegate
						{
							oper = button.Text;
							secondNumber = 0;
							isSetSecondNum = false;
							label.Text = string.Format("{0}", firstNumber) + oper;
						};
						break;
					case 3:
						str = "÷";
						button.Clicked += delegate
						{
							oper = button.Text;
							secondNumber = 0;
							isSetSecondNum = false;
							label.Text = string.Format("{0}", firstNumber) + oper;
						};
						break;
					case 4:
						str = "=";
						button.Clicked += delegate
						{
							if ("".Equals(oper))
							{
								label.Text = string.Format("{0}", firstNumber);
							}
							else if (isSetSecondNum == false)
							{
								label.Text = string.Format("{0}", firstNumber) + oper;
							}
							else {
								switch (oper)
								{
									case "+":
										firstNumber += secondNumber;
										break;
									case "-":
										firstNumber -= secondNumber;
										break;
									case "×":
										firstNumber *= secondNumber;
										break;
									case "÷":
										firstNumber /= secondNumber;
										break;
									default:
										firstNumber = 0;
										break;
								}
								secondNumber = 0;
								oper = "";
								label.Text = string.Format("{0}", firstNumber);
							}
						};
						break;
					case 5:
						str = "clear";
						button.Clicked += delegate
						{
							oper = "";
							firstNumber = 0;
							secondNumber = 0;
							isSetSecondNum = false;
							label.Text = string.Format("{0}", firstNumber);
						};
						break;
					default:
						break;
				}

				button.Text = str;
				button.OperString = str;

				if (i % 2 == 0)
				{
					button.BackgroundColor = Color.Aqua;
				}
				else {
					button.BackgroundColor = Color.Yellow;
				}

				operButtonList.Add(button);
			}
		}

	}
}
