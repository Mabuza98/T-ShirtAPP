using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using SQLite;
using A;

namespace Assignment8Tshirt.Models
{
    class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<CustDetails>().Wait();

        }

        public Task<List<CustDetails>> GetCustDetailsAsync()
        {
            return _database.Table<CustDetails>().ToListAsync();
        }

        public Task<int> SaveCustDetailsAsync(CustDetails custDetails)
        {
            return _database.InsertAsync(custDetails);
        }
    }
}