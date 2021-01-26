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
    public partial class InstagramPage : ContentPage
    {
        public InstagramPage()
        {
            InitializeComponent();
            string stringUri = "http://lorempixel.com/1920/1080/nature/3/";
            Uri url = new Uri(stringUri);
            FromUri(url);
        }

        
        public static ImageSource FromUri(Uri URL) {
            var urlMethod = URL;
            return urlMethod;
        }
    }
}