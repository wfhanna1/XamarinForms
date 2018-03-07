using NW.AL.Common.Interfaces;
using NW.AL.Interfaces;
using NW.AL.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NW.AL.Database
{
    public class ALDatabase : IALDatabase
    {
        private SQLiteConnection database { get; set; }

        private string dbPath;

        public ALDatabase()
        {
            dbPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("NWALSQLite.db3");
        }  
        private SQLiteConnection InitializeDatabase()
        {
            try
            {
                database = new SQLiteConnection(dbPath);
                if (!DoesTableExist(nameof(Tutorial)))
                {
                    database.CreateTable<Tutorial>();
                }
                return database;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public SQLiteConnection GetConnection() => database ?? InitializeDatabase();

        //public Task<List<T>> GetItemsAsync()
        //{
        //    return database.Table<T>().ToListAsync();
        //}

        //public Task<T> GetItemAsync(int id)
        //{
        //    return database.Table<T>().Where(i => i.ID == id).FirstOrDefaultAsync();
        //}

        //public Task<int> SaveItemAsync(ref T item)
        //{
        //    if (item.ID != 0)
        //    {
        //        return database.UpdateAsync(item);
        //    }
        //    else
        //    {
        //        return database.InsertAsync(item);
        //    }
        //}

        //public Task<int> DeleteItemAsync(ref T item)
        //{
        //    return database.DeleteAsync(item);
        //}

        private bool DoesTableExist(string tableName)
        {
            try
            {
                var exists = database.ExecuteScalar<int>($"SELECT count(*) FROM sqlite_master WHERE type='table' AND name='{tableName}';");
                return exists == 0 ? false : true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
