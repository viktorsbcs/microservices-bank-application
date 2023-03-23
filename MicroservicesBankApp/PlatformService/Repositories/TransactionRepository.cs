﻿using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _dbContext;

        public TransactionRepository(AppDbContext dbContext) {
            this._dbContext = dbContext;
        }
        public Task ExecuteTransaction(Account fromAccount, Account toAccount)
        {
            throw new NotImplementedException();
        }
    }
}
