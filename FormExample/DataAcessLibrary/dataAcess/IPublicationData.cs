using dataAcess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dataAcess
{
    public interface IPublicationData
    {
        Task<List<PublicationModel>> GetPublication();
        Task InsertPerson(PublicationModel publication);
    }
}