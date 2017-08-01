using System;
using Banking;
using System.Collections.Generic;
namespace Banking
{
    public interface IAccount
    {
        string AccountHolder { get; }
        decimal Balance { get; }
		List<ITransaction> Transactions {get;}
        void Deposit(decimal value);
        void Withdraw(decimal value);
        void Transfer(IAccount account, decimal value);
        void AddAccountHolder(IPerson customer);

	}
}