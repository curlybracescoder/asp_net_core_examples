using DI.Models;

namespace DI.Repositories
{
    public interface IUserRepository    
    {
        User[] GetAll();
        User GetByName(string name);        
    }
}