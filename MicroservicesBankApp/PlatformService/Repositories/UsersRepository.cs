﻿using PlatformService.Data;
using PlatformService.Interfaces;
using PlatformService.Models;
using PlatformService.Utilities;


namespace PlatformService.Repositories
{
    public class UsersRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UsersRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
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

            //Find if existing user with such if exist
            await _dbContext.Users.AddAsync(newUser);
            await _dbContext.SaveChangesAsync();
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
