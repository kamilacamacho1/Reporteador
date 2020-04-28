using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporteador.Data
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
