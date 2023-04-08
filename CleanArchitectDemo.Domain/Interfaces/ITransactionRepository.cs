using CleanArchitectDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectDemo.Domain.Interfaces
{
    public interface ITransactionRepository
    {


        Task AddTransactionAsync(Transaction transaction);
    }
}
