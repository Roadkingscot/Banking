using System;
using Banking;
namespace Banking
{
	public interface IAccount
	{
		string AccountHolder { get; }
		decimal Balance { get; }
		void Deposit(decimal value);
		void Withdraw(decimal value);
		void Transfer(IAccount account, decimal value);
		void AddAccountHolder(IPerson customer);
	}
}