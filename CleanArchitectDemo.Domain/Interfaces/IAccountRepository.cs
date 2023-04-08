using CleanArchitectDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectDemo.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account> GetByIdAsync(int id);
        Task<Account> GetByAccountNumberAsync(string accountNumber);
        Task AddAccountAsync(Account account);
        Task<IEnumerable<Account>> GetAllAccounts();   
        Task UpdateAsync (Account account);
    }
}
