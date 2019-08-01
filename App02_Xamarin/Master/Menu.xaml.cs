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
            Detail = new NavigationPage(new Pages.Perfil1());
            IsPresented = false;
        }

        private void GoPaginaXamarin(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
        }
    }
}
