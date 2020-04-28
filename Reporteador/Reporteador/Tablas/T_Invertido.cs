using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporteador.Tablas
{
    public class T_Invertido
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        public int Valor { get; set; }
    }
}
