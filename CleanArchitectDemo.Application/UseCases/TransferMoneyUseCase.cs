using CleanArchitectDemo.Application.Interfaces;
using CleanArchitectDemo.Domain.Entities;
using CleanArchitectDemo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectDemo.Application.UseCases
{
    public class TransferMoneyUseCase : ITransferMoneyUseCase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ITransactionRepository _transactionRepository;

        public TransferMoneyUseCase(ITransactionRepository transactionRepository, IAccountRepository accountRepository)
        {
            _transactionRepository = transactionRepository;
            _accountRepository = accountRepository;
        }

        public async Task TransferAmountAsync(int fromAccountId, int toAccountId, decimal amount)
        {
            var fromAccount = await _accountRepository.GetByIdAsync(fromAccountId);
            var toAccount = await _accountRepository.GetByIdAsync(toAccountId);
            


            if(fromAccount.Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            var transactionTo = new Transaction
            {
                AccountId = toAccountId,
                Amount = amount,
            };

            var transactionFrom = new Transaction
            {
                AccountId = fromAccountId,
                Amount = amount,
            };


            await _transactionRepository.AddTransactionAsync(transactionTo);
            await _transactionRepository.AddTransactionAsync(transactionFrom);

        }
    }
}
