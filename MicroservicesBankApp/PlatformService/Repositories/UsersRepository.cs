﻿using PlatformService.Data;
using PlatformService.Models;
using PlatformService.Utilities;


namespace PlatformService.Repositories
{
    public class UsersRepository : IUserReporsitory
    {
        private readonly AppDbContext _context;

        public UsersRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateUser(string firstName, string secondName)
        {
            var newUser = new User()
            {
                UserId = Helpers.GeneretaRandomUserId(),
                FirstName = firstName,
                SecondName = secondName,
                Accounts = new List<Account>()
            };

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
        }

        public Task<List<Account>> GetAccountsBelongingToUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string userId)
        {
            throw new NotImplementedException();
        }



    }


}
