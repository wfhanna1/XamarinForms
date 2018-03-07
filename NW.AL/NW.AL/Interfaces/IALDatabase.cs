using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NW.AL.Interfaces
{
    public interface IALDatabase
    {
        SQLiteConnection GetConnection();
    }
}
