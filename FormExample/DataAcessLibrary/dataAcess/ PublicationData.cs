using dataAcess.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using Dapper;


namespace dataAcess
{
    public class PublicationData : IPublicationData
    {
        private readonly ISqlDataAccess _db;

        public PublicationData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<PublicationModel>> GetPublication()
        {
            string sql = "select * from dbo.Publications";

            return _db.LoadData<PublicationModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PublicationModel publication)
        {
            string sql = @"insert into dbo.Publications (Title, Year)
                            values (@Title, @Year);";

            return _db.SaveData(sql, publication);
        }

        public Task InsertMultiplePersons(PublicationModel publication)
        {

            string sql = @"insert into dbo.Publications (Title, Year)
                            values (@Title, @Year);";
            return _db.SaveTransactionScopedData(sql, publication);
        }
    }
}