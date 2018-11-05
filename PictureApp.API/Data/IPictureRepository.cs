using System.Collections.Generic;
using System.Threading.Tasks;
using PictureApp.API.Models;

namespace PictureApp.API.Data
{
    public interface IPictureRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAllAsync();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);

    }
}