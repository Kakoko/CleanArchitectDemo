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
    public class TransactionRepository : ITransactionRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public TransactionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddTransactionAsync(Transaction transaction)
        {
            await _dbContext.Transactions.AddAsync(transaction);
            await _dbContext.SaveChangesAsync();
        }
    }
}
