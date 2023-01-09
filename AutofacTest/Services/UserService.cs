using AutofacTest.Data;
using AutofacTest.Data.Entities;

namespace AutofacTest.Services
{
    public class UserService : IUserService
    {
        private readonly DbModel _context;

        public UserService(DbModel context)
        {
            _context = context;
        }

        public User Add(User user)
        {
            var savedUser = _context.users.Add(user);
            _context.SaveChanges();

            return savedUser.Entity;
        }
    }
}
