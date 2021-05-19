using System;
using System.Collections.Generic;
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
        public IList<EstadosLlamados> Estados { get; private set; }
        public MainEstados()
        {
            InitializeComponent();
            Estados = new List<EstadosLlamados>();

            Estados.Add(new EstadosLlamados
            {
                Name = "Chihuahua",
                Ubicacion = "Norte",
                Url = "https://spng.pngfind.com/pngs/s/88-880663_estado-de-chihuahua-png-estado-de-chihuahua-vector.png"
            });

            Estados.Add(new EstadosLlamados
            {
                Name = "Chihuahua",
                Ubicacion = "Norte",
                Url = "https://spng.pngfind.com/pngs/s/88-880663_estado-de-chihuahua-png-estado-de-chihuahua-vector.png"
            });

            Estados.Add(new EstadosLlamados
            {
                Name = "Chihuahua",
                Ubicacion = "Norte",
                Url = "https://spng.pngfind.com/pngs/s/88-880663_estado-de-chihuahua-png-estado-de-chihuahua-vector.png"
            });

            Estados.Add(new EstadosLlamados
            {
                Name = "Chihuahua",
                Ubicacion = "Norte",
                Url = "https://spng.pngfind.com/pngs/s/88-880663_estado-de-chihuahua-png-estado-de-chihuahua-vector.png"
            });

            Estados.Add(new EstadosLlamados
            {
                Name = "Chihuahua",
                Ubicacion = "Norte",
                Url = "https://spng.pngfind.com/pngs/s/88-880663_estado-de-chihuahua-png-estado-de-chihuahua-vector.png"
            });



        }
    }
}
