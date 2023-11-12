namespace DataLayer;
public interface ICardRepository{
   Task<CardModel> Find(int id);
   Task<List<CardModel>> FindAll();
}
