using System;
using Microsoft.VisualBasic;
using Xamarin.Forms;

namespace RadialProgressDemo
{public class myCsub_about : ContentPage
{
	public myCsub_about()
	{
		NavigationPage.SetHasNavigationBar(this, false);
		BackgroundImage = "aboutWallpaper.jpg";

		var blogURILabel = new Label()
		{
			Text = "https://www.cs.csub.edu/~parkingapp",
			TextColor = Color.Blue,
			FontSize = 22,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Start
		};

		var tgr = new TapGestureRecognizer();
		tgr.Tapped += async (s, e) =>
		{
			try
			{
				Device.OpenUri(new Uri("https://www.cs.csub.edu/~parkingapp"));
			}
			catch (Exception ex)
			{
					//
				}
		};
		blogURILabel.GestureRecognizers.Add(tgr);


		Content = new StackLayout
		{
			Padding = 5,
			VerticalOptions = LayoutOptions.Center,
			Children =
				{
				new Label
				{
					Text = "Parking spots fill up fast and it can be difficult to find parking currently or to know when a space will be free in the near future\nSOLUTION:\nAndroid App to save a user’s current location in a parking lot on campus.\n",
					Font = Font.SystemFontOfSize(NamedSize.Large),
					HorizontalOptions = LayoutOptions.Center,
				},
				blogURILabel,
				new Label
				{
					Text = "Senior Project 2k17\n",
					Font = Font.SystemFontOfSize(NamedSize.Large),
					HorizontalOptions = LayoutOptions.Center,
				},
				}
		};

	}
}
}
