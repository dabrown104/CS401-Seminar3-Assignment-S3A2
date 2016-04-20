using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloSap
{
	public class App : Application
	{
		public App ()
		{


        #if __IOS__
            // iOS specific code
        #elif __ANDROID__
            // Android specific code
        #elif WINDOWS_UWP
            // Universal Windows Platform specific code
        #elif WINDOWS_APP
            // Windows 8.1 specific code
        #elif WINDOWS__PHONE_APP
            // Windows Phone 8.1 specific code
        #endif

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
