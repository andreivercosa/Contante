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
        int i = 1;
        public MainPage()
        {
           
            InitializeComponent();

        }

        void ClicadaDoBotao(object sender, EventArgs e)
        {
            if (i % 2 != 0) { 
                label_status.Text = "VOCE CLICOU";
                button_meClica.Text = "CLICADO";
            }
            if (i % 2 == 0)
            {
                label_status.Text = "VAMOS NESSA";
                button_meClica.Text = "ME CLICA";
            }
            i++;
        }

    }
}
