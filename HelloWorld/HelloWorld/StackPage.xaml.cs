using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();

            #region UnusuableCode
            //The way to set a layout of the page from code
           /* var layout = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
                Spacing = 20,
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            layout.Children.Add(new Label { Text = "Label 1" });
            layout.Children.Add(new Label { Text = "Label 2" });
            layout.Children.Add(new Label { Text = "Label 3" });

            Content = layout;*/
            #endregion
        }
    }
}