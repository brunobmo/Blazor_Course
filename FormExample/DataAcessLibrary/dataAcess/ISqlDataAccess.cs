using System.Collections.Generic;
using System.Threading.Tasks;

namespace dataAcess
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);

        Task SaveTransactionScopedData<T>(string sql, T parameters);
    }
}