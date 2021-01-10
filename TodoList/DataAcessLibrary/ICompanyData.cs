using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ICompanyData
    {
        Task<List<CompanyModel>> GetCompany();
        Task InsertCompany(CompanyModel person);
    }
}