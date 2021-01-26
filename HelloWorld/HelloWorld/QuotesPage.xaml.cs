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
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
        }

        int count = 0;

        string[] Quotes = {"La paciencia es amarga, pero sus frutos son dulces.",
            "El futuro tiene muchos nombres.",
            "Para los temerosos, lo desconocido.",
            "Para los valientes es la oportunidad.",
            "Para los débiles es lo inalcanzable.",
            "En algún momento hay que decidirse. Los muros no mantienen a los demás fuera, sino a ti dentro. La vida es un caos, somos así.", 
            "La magia de arriesgarlo todo por un sueño que nadie ve, excepto tú.",
            "No era la voluntad de ganar, era la voluntad de prepararse para ganar lo que marcaba la diferencia.",
            "Puedes pasarte la vida levantando muros, o puedes vivirla saltándolos."};
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            while (count == 9)
            {
                count = 0;
            }
            var quotes = Quotes[count];

            labelText.Text = quotes;

        }
    }
}