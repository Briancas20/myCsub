using Xamarin.Forms;

namespace RadialProgressDemo
{
	public class myCsub_livestats : ContentPage
	{
		private RadialProgress radialProgressStats1;//K1 kroll way
		private RadialProgress radialProgressStats2;//K2 Stockdale Parking lot
		private RadialProgress radialProgressStats3;//J Stockdale Parking lot
		private RadialProgress radialProgressStats4;//M Student Union parking
		private RadialProgress radialProgressStats5;//D library 
		private RadialProgress radialProgressStats6;//C Artbuilding/Theater
		private RadialProgress radialProgressStats7;//B Artbuilding/Theater
		private RadialProgress radialProgressStats8;//A Artbuilding/Theater
		private RadialProgress radialProgressStats9;//E old Dorms
		private RadialProgress radialProgressStats10;//F Business Buildings
		private RadialProgress radialProgressStats11;//G Baseballfields
		private RadialProgress radialProgressStats12;//H Icardo
		private RadialProgress radialProgressStats13;//I pool parkinglot 


		Label topLeftLabel, centerLabel, bottomRightLabel;
		public myCsub_livestats()
		{
			NavigationPage.SetHasNavigationBar(this, false);
			Title = " myCSUB Pakring Stats";
			var borderColor = new Color((double)216 / 255, (double)26 / 255, (double)36 / 255, 0.7);
			var fillColor = new Color((double)6 / 255, (double)27 / 255, (double)142 / 255, 0.5);
			var textColor = new Color((double)255 / 255, (double)255 / 255, (double)38 / 255, 1);

			var headerInfo = new Label
			{
				Text = "Current Stats on Parking Lots",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Center,
				TextColor = textColor,
				BackgroundColor = borderColor
			};



			radialProgressStats1 = new RadialProgress
			{
				Progress = 81,
				Diameter = 180,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "K1 kroll way",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats2 = new RadialProgress
			{
				// the progress should be connected to a function that shows the current availability 
				Progress = 97,
				Diameter = 150,
				BorderColor = borderColor,
				MaxReachedBorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "K2 Parking lot",
				DisplayMode = DisplayModeTypes.ShowProgress
			};
			radialProgressStats3 = new RadialProgress
			{
				Progress = 65,
				Diameter = 100,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "J Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};

			radialProgressStats4 = new RadialProgress
			{

				Progress = 71,
				Diameter = 98,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "M SU Parking Lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats5 = new RadialProgress
			{
			 	Progress = 89,
				Diameter = 93,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "D Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats6 = new RadialProgress
			{

				Progress = 65,
				Diameter = 91,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "C Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats7 = new RadialProgress
			{
				Progress = 95,
				Diameter = 90,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "B Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats8 = new RadialProgress
			{
				Progress = 84,
				Diameter = 100,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "A Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats9 = new RadialProgress
			{
				Progress = 95,
				Diameter = 100,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "E Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};

			radialProgressStats10 = new RadialProgress
			{
				Progress = 99,
				Diameter = 94,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "F Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats11 = new RadialProgress
			{ 	
				Progress = 83,
				Diameter = 92,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "G Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats12 = new RadialProgress
			{
				Progress = 89,
				Diameter = 95,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "H Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			radialProgressStats13 = new RadialProgress
			{

				Progress = 85,
				Diameter = 97,
				BorderColor = borderColor,
				FillColor = fillColor,
				TextColor = textColor,
				ProgressText = "I Parking lot",
				DisplayMode = DisplayModeTypes.ShowPercentage
			};
			var simpleLayout = new AbsoluteLayout
			{
				//BackgroundColor = Color.Blue.WithLuminosity(0.9),
				VerticalOptions = LayoutOptions.FillAndExpand
			};


			// refresh button should have functionality where tables can be updated.
			var btnReset = new Button
			{
				Text = "Refresh",
				TextColor = textColor,
				BackgroundColor = borderColor
			};

			AbsoluteLayout.SetLayoutFlags(radialProgressStats1, AbsoluteLayoutFlags.PositionProportional);

			AbsoluteLayout.SetLayoutBounds(radialProgressStats1, new Rectangle(0.6, 0.1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(radialProgressStats2, AbsoluteLayoutFlags.PositionProportional);

			AbsoluteLayout.SetLayoutBounds(radialProgressStats2, new Rectangle(1f, 0.3, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(radialProgressStats3,
				AbsoluteLayoutFlags.PositionProportional);

			AbsoluteLayout.SetLayoutBounds(radialProgressStats3,
				new Rectangle(1f, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(radialProgressStats4,
				AbsoluteLayoutFlags.PositionProportional);

			AbsoluteLayout.SetLayoutBounds(radialProgressStats4,
				new Rectangle(1f, .7, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutBounds(radialProgressStats5,
			new Rectangle(1f, 78.54, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);


			AbsoluteLayout.SetLayoutBounds(radialProgressStats6,
				new Rectangle(106.56, 93.9, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(radialProgressStats7,
				new Rectangle(34.6, 198.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(radialProgressStats8,
				new Rectangle(48.7, 298.9, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(radialProgressStats9,
				new Rectangle(99.6, 396.1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(radialProgressStats10,
				new Rectangle(72, 495.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(radialProgressStats11,
				new Rectangle(56, 592.2, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(radialProgressStats12,
				new Rectangle(1f, 694.3, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(radialProgressStats13,
				new Rectangle(1f, 804.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(btnReset,
				AbsoluteLayoutFlags.PositionProportional);






			AbsoluteLayout.SetLayoutBounds(btnReset,
				new Rectangle(0.5f,
					1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			AbsoluteLayout.SetLayoutFlags(headerInfo,
				AbsoluteLayoutFlags.PositionProportional);

			AbsoluteLayout.SetLayoutBounds(headerInfo,
				new Rectangle(0.1f,
					0.0f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			var progressOneTapGesture = new TapGestureRecognizer();
			progressOneTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats1.Progress++;
			};
			radialProgressStats1.GestureRecognizers.Add(progressOneTapGesture);

			var progressTwoTapGesture = new TapGestureRecognizer();
			progressTwoTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats2.Progress++;
			};
			radialProgressStats2.GestureRecognizers.Add(progressTwoTapGesture);

			var progressThreeTapGesture = new TapGestureRecognizer();
			progressThreeTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats3.Progress++;
			};
			radialProgressStats3.GestureRecognizers.Add(progressThreeTapGesture);

			var progressFourTapGesture = new TapGestureRecognizer();
			progressFourTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats4.Progress++;
			};
			radialProgressStats5.GestureRecognizers.Add(progressFourTapGesture);

			var progressFiveTapGesture = new TapGestureRecognizer();
			progressFiveTapGesture.Tapped += async (s, e) =>
		{
			radialProgressStats5.Progress++;
		};
			radialProgressStats5.GestureRecognizers.Add(progressFiveTapGesture);
			/////////////////////////////////////////////////////////////////////////////////////////			var progressFiveTapGesture = new TapGestureRecognizer();
			progressFiveTapGesture.Tapped += async (s, e) =>
		{
			radialProgressStats5.Progress++;
		};
			radialProgressStats5.GestureRecognizers.Add(progressFiveTapGesture);


			var progressSixTapGesture = new TapGestureRecognizer();
			progressSixTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats6.Progress++;
			};
			radialProgressStats6.GestureRecognizers.Add(progressSixTapGesture);

			var progressSevenTapGesture = new TapGestureRecognizer();
			progressSevenTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats7.Progress++;
			};
			radialProgressStats7.GestureRecognizers.Add(progressSevenTapGesture);

			var progressEightTapGesture = new TapGestureRecognizer();
			progressEightTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats8.Progress++;
			};
			radialProgressStats8.GestureRecognizers.Add(progressEightTapGesture);

			var progressNineTapGesture = new TapGestureRecognizer();
			progressNineTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats9.Progress++;
			};
			radialProgressStats9.GestureRecognizers.Add(progressNineTapGesture);

			var progressTenTapGesture = new TapGestureRecognizer();
			progressTenTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats10.Progress++;
			};
			radialProgressStats10.GestureRecognizers.Add(progressTenTapGesture);

			var progressElevenTapGesture = new TapGestureRecognizer();
			progressElevenTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats11.Progress++;
			};
			radialProgressStats11.GestureRecognizers.Add(progressElevenTapGesture);


			var progressTwelveTapGesture = new TapGestureRecognizer();
			progressTwelveTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats12.Progress++;
			};
			radialProgressStats12.GestureRecognizers.Add(progressTwelveTapGesture);

			var progressThirteenTapGesture = new TapGestureRecognizer();
			progressThirteenTapGesture.Tapped += async (s, e) =>
			{
				radialProgressStats13.Progress++;
			};
			radialProgressStats13.GestureRecognizers.Add(progressThirteenTapGesture);





			btnReset.Clicked += (sender, args) =>
			{
				radialProgressStats1.Progress = 0;
				radialProgressStats2.Progress = 0;
				radialProgressStats3.Progress = 0;
				radialProgressStats4.Progress = 0;
				radialProgressStats5.Progress = 0;
				radialProgressStats6.Progress = 0;
				radialProgressStats7.Progress = 0;
				radialProgressStats8.Progress = 0;
				radialProgressStats9.Progress = 0;
				radialProgressStats10.Progress = 0;
				radialProgressStats11.Progress = 0;
				radialProgressStats12.Progress = 0;
				radialProgressStats13.Progress = 0;

			};

			simpleLayout.Children.Add(headerInfo);
			simpleLayout.Children.Add(radialProgressStats1);
			simpleLayout.Children.Add(radialProgressStats2);
			simpleLayout.Children.Add(radialProgressStats3);
			simpleLayout.Children.Add(radialProgressStats4);
			simpleLayout.Children.Add(radialProgressStats5);
			simpleLayout.Children.Add(radialProgressStats6);
			simpleLayout.Children.Add(radialProgressStats7);
			simpleLayout.Children.Add(radialProgressStats8);
			simpleLayout.Children.Add(radialProgressStats9);
			simpleLayout.Children.Add(radialProgressStats10);
			simpleLayout.Children.Add(radialProgressStats11);
			simpleLayout.Children.Add(radialProgressStats12);
			simpleLayout.Children.Add(radialProgressStats13);


			simpleLayout.Children.Add(btnReset);

			// Accomodate iPhone status bar.
			this.Padding =
				new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			var headerInfoLayout = new StackLayout
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Orientation = StackOrientation.Horizontal,
				Children =
						{
							new Label
							{
								Text = "myCsub Parking",
								FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label))
							}
						}
			};
			var headerLayout = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.Start,
				Children =
				{
				   headerInfoLayout
				}
			};

			var contentLayout = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children =
				{

				}
			};
			var footerLayout = new StackLayout
			{
				HorizontalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.End,
				Children =
				{
                    //radialProgress,
                    new Label
					{
							Text = "myCsubParking 10.5"
					}
				}
			};
			BackgroundImage = "Runner.jpg";
			// The root page of your application

			Content = new StackLayout
			{
				// this must be fill and expand in order for this to work
				// VerticalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
                    // headerLayout,
                    simpleLayout,
					footerLayout
				}
			};

		}
	}
}
