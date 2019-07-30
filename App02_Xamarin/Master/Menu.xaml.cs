using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App02_Xamarin.Master
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoPaginaPerfil1(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Perfil1());
        }

        private void GoPaginaXamarin(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Xamarin());
        }
    }
}
