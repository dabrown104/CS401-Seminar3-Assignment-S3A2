using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
    public partial class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            Content = new Label
            {
                Text = "Greetings, Xamarin.Forms!",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            Device.OnPlatform(iOS: () =>
            {
                Padding = new Thickness(0, 20, 0, 0);
            });
        }
    }
}
