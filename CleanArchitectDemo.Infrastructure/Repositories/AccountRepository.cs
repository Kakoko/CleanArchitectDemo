using CleanArchitectDemo.Domain.Entities;
using CleanArchitectDemo.Domain.Interfaces;
using CleanArchitectDemo.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectDemo.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
            private readonly ApplicationDbContext _dbContext;

            public AccountRepository(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

        public async Task AddAccountAsync(Account account)
        {
            await _dbContext.Accounts.AddAsync(account);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public async Task<Account> GetByAccountNumberAsync(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<Account> GetByIdAsync(int id)
        {
            return await _dbContext.Accounts.FindAsync(id);
        }

        public async Task UpdateAsync(Account account)
        {
            _dbContext.Accounts.Update(account);
            await _dbContext.SaveChangesAsync();
        }
    }
}
