using bookStore.Models.Dominz;

namespace bookStore.Repo.Abs
{
     public interface IAuthorService
    {
          bool Add(Author model); 

          bool Update(Author model);

          bool Delete(int id);

          Author FindById(int id);

          IEnumerable<Author> GetAll(); 
     }
}
