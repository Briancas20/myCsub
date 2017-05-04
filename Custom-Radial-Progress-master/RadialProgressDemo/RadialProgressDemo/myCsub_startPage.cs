
using Xamarin.Forms;

namespace RadialProgressDemo
{
    public class myCsub_startPage : ContentPage
{
public myCsub_startPage()
	{
		NavigationPage.SetHasNavigationBar(this, false);
		BackgroundImage = "CSUB.jpg";
		var openSpotsbtn = new Button
		{
			Text = "Open Spots",
			TextColor = Color.Blue,
			BackgroundColor = Color.White
		};
		var campusUsagebtn = new Button
		{
			Text = "Campus Wide Usage",
			TextColor = Color.Blue,
			BackgroundColor = Color.White
		};
		var liveStatsbtn = new Button
		{
			Text = "Live Stats",
			TextColor = Color.Blue,
			BackgroundColor = Color.White
			// add function to update user location and proximity to parking lot 
		};
		var btnAbout = new Button
		{
			Text = "About/Extras",
			TextColor = Color.Blue,
			BackgroundColor = Color.White
		};
		/////////////////////////////////////////////////////////////////////////////////
		/// 
		/// 
		/// 
		// These are the buttons and what they do when clicked
		openSpotsbtn.Clicked += async (sender, e) =>
		{
			await Navigation.PushAsync(new myCsub_Progress());
		};
		campusUsagebtn.Clicked += async (sender, e) =>
		{
			await Navigation.PushAsync(new myCsub_CampusP());
		};
		liveStatsbtn.Clicked += async (sender, e) =>
		{
			await Navigation.PushAsync(new myCsub_livestats());
		};
		btnAbout.Clicked += async (sender, args) =>
		{
			await Navigation.PushAsync(new myCsub_about());
		};
		Content = new StackLayout
		{
			// fill and expand in order for this to work, this is a must

			// VerticalOptions = LayoutOptions.FillAndExpand,
			Padding = 5,
			VerticalOptions = LayoutOptions.Center,
			Children =
				{
					openSpotsbtn,
					campusUsagebtn,
					liveStatsbtn,
					btnAbout
			   }
		};

	}
}
}