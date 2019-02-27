using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace Contante
{
    public partial class MainPage : ContentPage
    {
        public int i = 0;
        public MainPage()
        {
           
            InitializeComponent();

        }

        void ClicadaDoBotao(object sender, EventArgs e)
        {
                i++;
                label_status.Text = "VOCE CLICOU "+ i + "VEZES";
                button_meClica.Text = "CLICADO";
                
        }

    }
}
