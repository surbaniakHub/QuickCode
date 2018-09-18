using System.Threading.Tasks;
// Model User required.

namespace MyProject.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}

// namespace MyProject.Models
// {
//     public class User
//     {
//         public int Id { get; set; }
//         public string Username { get; set; }
//         public byte[] PasswordHash { get; set; }
//         public byte[] PasswordSalt { get; set; }
//     }
// }