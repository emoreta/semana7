using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace S7EdisonMoreta9A
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
