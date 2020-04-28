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
    public partial class UI_Registro : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public UI_Registro()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
        }

        protected void btn_agregar(object sender, EventArgs e)
        {
            var DatosRegistro = new T_Invertido { Fecha  = Fecha.Date , Valor = Convert.ToInt32 ( Valor.Text)};
            _conn.InsertAsync(DatosRegistro);
            limpiarFormulario();
        }
        void limpiarFormulario()
        {
            Fecha.Date = DateTime.Now ;
            Valor.Text = "";            
            DisplayAlert("Reporting", "Se agregó correctamente", "Ok");
        }

    }
}