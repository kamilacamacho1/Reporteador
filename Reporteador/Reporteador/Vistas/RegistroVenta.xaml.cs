using Reporteador.Data;
using Reporteador.Tablas;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reporteador.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroVenta : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public RegistroVenta()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            _conn.CreateTableAsync<T_Ventas>();
            //_conn.CreateTableAsync<T_Ventas>().ConfigureAwait(false);
            //_conn.CreateTableAsync<T_Ventas>().ConfigureAwait(false);
        }

        private void btn_agregarVenta(object sender, EventArgs e)
        {
            var ventaNormal = 8000;
            var DatosRegistro = new T_Ventas { Fecha = DateTime.Now, Valor = ventaNormal, Nombre = "Almuerzo Ejecutivo Completo" };
            _conn.InsertAsync(DatosRegistro);
            limpiarFormulario();
        }
        void limpiarFormulario()
        {            
            ValorVenta.Text = "";
            DisplayAlert("Reporting", "Se agregó correctamente", "Ok");
        }
    }
}