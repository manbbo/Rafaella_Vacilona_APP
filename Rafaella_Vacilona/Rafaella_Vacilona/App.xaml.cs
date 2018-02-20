using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Rafaella_Vacilona
{
	public partial class App : Application
	{
		public App ()
		{
            InitializeComponent();

            MainPage = new NavigationPage(new Rafaella_Vacilona.MainPage()) { BarBackgroundColor = Color.FromRgb(159, 31, 31), BackgroundColor = Color.FromRgb(60, 58, 58) };
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
