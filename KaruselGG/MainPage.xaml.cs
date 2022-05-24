using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KaruselGG
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var redContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Качественный ноутбук, который отлично подходит как для работы, так и для развлечений.",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "lenovo1.png"
                        }
                    }
                }

            };
                 var greenContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Green",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new BoxView
                        {
                            Color = Color.Green,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand }
                    }
                }
            };
                 var blueContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Blue",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new BoxView
                        {
                            Color = Color.Blue,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand }
                    }
                }
            };
            Children.Add(redContentPage);
            Children.Add(greenContentPage);
            Children.Add(blueContentPage);
        }
    }
}
