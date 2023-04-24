using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Registro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
        }
        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string dato1 = txtDato.Text;
            string dato2 = txtDatodos.Text;

            Navigation.PushAsync(new Registro(dato1, dato2));
        }
    }
}