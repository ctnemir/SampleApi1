using SampleApi1.Models;

namespace SampleApi1.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
