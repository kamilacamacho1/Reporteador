using System;
using System.Collections.Generic;
using System.Text;

namespace Reporteador.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Registrar,
        RegistrarVenta,
        ListadoVentas
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
