using DAL.Entities;

namespace DAL.IDALServices
{
    public interface IUserService
    {
        Task CreateUser(User newUser);
        Task<User?> FindAccountByEmail(string email);
        Task<User?> FindAccountById(int id);
    }
}
