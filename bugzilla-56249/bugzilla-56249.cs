using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace bugzilla56249
{
    public class App : Application
    {
        private Picker _picker;

		public static Dictionary<string, string> countryCode = new Dictionary<string, string>
		{
			{ "Australia (+61)", "+61" },
			{ "Brunei (+673)", "+673" },
			{ "Cambodia (+855)", "+855" },
			{ "China (+86)", "+86" },
			{ "Fiji (+679)", "+679" },
			{ "France (+33)", "+33" },
			{ "Germany (+49)", "+49" },
			{ "Hong Kong (+852)", "+852" },
			{ "India (+91)", "+91" },
			{ "Indonesia (+62)", "+62" },
			{ "Japan (+81)", "+81" },
			{ "Malaysia (+60)", "+60" },
			{ "Macau (+853)", "+853" },
			{ "Maldives (+960)", "+960" },
			{ "Singapore (+65)", "+65" },
			{ "Thailand (+66)", "+66" },
			{ "Philippines (+63)", "+63" },
			{ "South Korea (+82)", "+82" },
			{ "United Arab Emirates (+971)", "+971" },
			{ "United Kingdom (+44)", "+44" },
			{ "United States (+1)", "+1" },
			{ "Vatican (+379)", "+379" },
			{ "Vietnam (+84)", "+84" }
		};

        public App()
        {
            _picker = new Picker
            {

                Title = "Select the country code",
                HorizontalOptions = LayoutOptions.Center
            };

			foreach (string countryInfo in countryCode.Keys)
			{
				_picker.Items.Add(countryInfo);
			}

			// The root page of your application
			var content = new ContentPage
            {
                Title = "bugzilla-56249",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(5, 20, 5, 20),
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Bug 56249\n\nText in a horizontally-centered picker\nis shown as center-justified during selection,\nbut is shown as left-justified once selected"
                        },
                        _picker
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
