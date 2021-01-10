using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CompanyData : ICompanyData
    {
        private readonly ISqlDataAccess _db;

        public CompanyData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CompanyModel>> GetCompany()
        {
            string sql = "select * from dbo.People";

            return _db.LoadData<CompanyModel, dynamic>(sql, new { });
        }

        public Task InsertCompany(CompanyModel company)
        {
            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress)
                           values (@FirstName, @LastName, @EmailAddress);";

            return _db.SaveData(sql, company);
        }
    }
}
