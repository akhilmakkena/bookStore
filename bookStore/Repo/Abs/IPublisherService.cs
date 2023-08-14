using bookStore.Models.Dominz;

namespace bookStore.Repo.Abs
{
     public interface IPublisherService
    {
          bool Add(Publisher model);  

          bool Update(Publisher model);

          bool Delete(int id);

          Publisher FindById(int id);

          IEnumerable<Publisher> GetAll(); 
     }
}
