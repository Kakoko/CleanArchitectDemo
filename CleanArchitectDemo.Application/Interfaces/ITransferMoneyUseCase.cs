using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectDemo.Application.Interfaces
{
    public interface ITransferMoneyUseCase
    {
        Task TransferAmountAsync(int fromAccountId , int toAccountId , decimal amount);
    }
}
