namespace DataLayer;
public class CardRepository : ICardRepository
{
    private ISqlDataAccess _db;
    public CardRepository(ISqlDataAccess db)
    {
        _db = db;
    }
    public Task<CardModel> Find(int id)
    {
        throw new NotImplementedException();
    }
    public Task<List<CardModel>> FindAll()
    {
        string sql = "select * from Cards";
        return _db.LoadData<CardModel, dynamic>(sql, new { });
    }
}