using Reporteador.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reporteador.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UI_ConsultaRegistro : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        private ObservableCollection<T_Ventas> _TablaVentas;
        public UI_ConsultaRegistro()
        {
            InitializeComponent();
            _conn = DependencyService.Get<ISQLiteDB>().GetConnection();
            //NavigationPage.SetHasBackButton(this, false);
        }

        protected async override void OnAppearing()
        {
            try
            {
                var ResulRegistros = await _conn.Table<T_Ventas>().ToListAsync();
                _TablaVentas = new ObservableCollection<T_Ventas>(ResulRegistros);
                ListaVentas.ItemsSource = _TablaVentas;
                base.OnAppearing();
            }
            catch (Exception ex)
            {

                DisplayAlert("Reporting", "Error al listar las ventas", "Ok");
            }
            
        }
        //void OnSelection(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var Obj = (T_Ventas)e.SelectedItem;
        //    var item = Obj.Id.ToString();
        //    int ID = Convert.ToInt32(item);
        //    try
        //    {
        //        //Navigation.PushAsync(new UI_Elemento(ID));
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}