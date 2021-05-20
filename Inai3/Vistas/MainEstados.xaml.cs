using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inai3.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainEstados : ContentPage
    {
        public IList<Estado> Estados { get; private set; }
        public MainEstados()
        {
            InitializeComponent();
            Estados = new List<Estado>();

            Estados.Add(new Estado
            {
                Name = "Baja California",
                Ubicacion = "Norte",
                Url = "https://www.meteored.mx/mapas/png/67.png"
            });

            Estados.Add(new Estado
            {
                Name = "Chihuahua",
                Ubicacion = "Chihuahua",
                Url = "https://www.pngkit.com/png/full/969-9694802_chihuahua-mapa-png-estado-de-chihuahua-vector.png"
            });

            Estados.Add(new Estado
            {
                Name = "Mexico",
                Ubicacion = "Centro",
                Url = "https://www.pikpng.com/pngl/b/333-3339461_maps-estado-mexico-clipart.png"
            });

            Estados.Add(new Estado
            {
                Name = "Sinaloa",
                Ubicacion = "Norte",
                Url = "https://www.meteored.mx/mapas/png/90.png"
            });
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Estado selectedItem = e.SelectedItem as Estado;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Estado tappedItem = e.Item as Estado;
        }
    }
}