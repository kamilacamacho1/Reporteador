using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporteador
{
    public class T_Ventas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Valor { get; set; }
    }
}
