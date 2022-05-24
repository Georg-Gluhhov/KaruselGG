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
        Image img1, img2, img3;
        public MainPage()
        {

            img1 = new Image
            {
                Source = "lenovo1.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };
            img2 = new Image
            {
                Source = "huawei1.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };
            img3 = new Image
            {
                Source = "mac1.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            TapGestureRecognizer tap2 = new TapGestureRecognizer();
            tap2.Tapped += Tap2_Tapped;
            TapGestureRecognizer tap3 = new TapGestureRecognizer();
            tap3.Tapped += Tap3_Tapped;




            img1.GestureRecognizers.Add(tap);
            img2.GestureRecognizers.Add(tap2);
            img3.GestureRecognizers.Add(tap3);








            var redContentPage = new ContentPage
            {
                BackgroundColor = Color.White,
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Качественный ноутбук, который отлично подходит как для работы, так и для развлечений.",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor=Color.Black
                        },



                                                img1
                    }
                }

            };
                 var greenContentPage = new ContentPage
            {
                     BackgroundColor = Color.White,
                     Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Ноутбук HUAWEI MateBook 14 c полезной площадью 90% и экраном 2K FullView с соотношением сторон 3:2 значительно повысит Вашу продуктивность.",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center,
                                                        TextColor=Color.Black
                        },
                        img2
                    }
                }
            };
                 var blueContentPage = new ContentPage
            {
                     BackgroundColor = Color.White,
                     Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Серьёзно прибавил.С появлением чипа M1 MacBook Pro 13 дюймов становится невероятно про­из­во­ди­тель­ным и быстрым. Наш самый популярный ноутбук класса Pro выходит на совершенно новый уровень.",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center,
                                                        TextColor=Color.Black
                        },
                        img3
                    }
                }
            };
            Children.Add(redContentPage);
            Children.Add(greenContentPage);
            Children.Add(blueContentPage);
        }

        private void Tap3_Tapped(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("https://www.euronics.ee/ru/it/noutbuki/noutbuki/z11c00124/noutbuk-apple-macbook-pro-13-m1-512-gb-swe"));
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }

        private void Tap2_Tapped(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("https://www.euronics.ee/ru/it/noutbuki/noutbuki/53011cbd/noutbuk-huawei-matebook-14-2k"));
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("https://www.euronics.ee/ru/it/noutbuki/noutbuki/20vg006smx/noutbuk-lenovo-thinkbook-15-g2-are"));
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }
    }
}
