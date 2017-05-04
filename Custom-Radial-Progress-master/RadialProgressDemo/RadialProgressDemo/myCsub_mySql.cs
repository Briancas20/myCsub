using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;
using System.Net;
using System.Collections.Specialized;
using System.Text;

namespace MySQLTest
{
	[Activity(Label = "MySQLTest", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private Button button;
		private EditText txtEmail;
		private EditText txtPass;
		string back = "";
		string count;
		int id;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			button = FindViewById<Button>(Resource.Id.btn);
			button.Click += (object sender, EventArgs e) =>
			{
				WebClient client = new WebClient();
				var param = new System.Collections.Specialized.NameValueCollection();
				txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
				txtPass = FindViewById<EditText>(Resource.Id.txtPass);
				param.Add("email", txtEmail.Text);
				param.Add("pin", txtPass.Text);
				Uri uri = new Uri("http://www.cs.csubak.edu/~parkingapp/validate.php");
				client.UploadValuesCompleted += login_UploadValuesCompleted;
				client.UploadValuesAsync(uri, param);
			};
		}

		void demo_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
		{
			RunOnUiThread(() =>
			{
				count = Encoding.UTF8.GetString(e.Result); //Get the data echo back from PHP
				AlertDialog.Builder alert = new AlertDialog.Builder(this);
				alert.SetTitle("The Number of Users is:");
				alert.SetMessage(count);
				alert.SetNeutralButton("OK", (senderAlert, args) =>
				{
				});
				Dialog dialog = alert.Create();
				dialog.Show();
			});
		}

		void login_UploadValuesCompleted(object sender, UploadValuesCompletedEventArgs e)
		{
			RunOnUiThread(() =>
			{
				back = Encoding.UTF8.GetString(e.Result); //Get the data echo back from PHP
				if (int.TryParse(back, out id))
				{
					WebClient client2 = new WebClient();
					var param2 = new System.Collections.Specialized.NameValueCollection();
					txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
					param2.Add("email", txtEmail.Text);
					Console.WriteLine(id);

					Uri uri2 = new Uri("http://www.cs.csubak.edu/~parkingapp/demo.php");
					client2.UploadValuesCompleted += demo_UploadValuesCompleted;
					client2.UploadValuesAsync(uri2, param2);
				}
				else
				{
					AlertDialog.Builder alert = new AlertDialog.Builder(this);
					alert.SetTitle("Login Failed!");
					alert.SetMessage("Press OK to try again");
					alert.SetNeutralButton("OK", (senderAlert, args) =>
					{
					});
					Dialog dialog = alert.Create();
					dialog.Show();
					txtEmail.Text = "";
					txtPass.Text = "";
				}
			});
		}
	}
}
