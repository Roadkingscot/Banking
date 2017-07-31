using System;
using Banking;
using System.Collections.Generic;

namespace BankingApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Customer customer1 = new Customer("Scot", "Haynes");
			BankAccount bankaccount1 = new BankAccount("Santander", "05356435", 120.05m);
			customer1.AddAccount(bankaccount1);

			BankAccount bankaccount2 = new BankAccount("Halifax", "123456", 3000.23m);
			customer1.AddAccount(bankaccount2);

			BankAccount bankaccount3 = new BankAccount("Lloyds", "66778899", 26.55m);
			customer1.AddAccount(bankaccount3);

			BankAccount bankaccount4 = new BankAccount("Barclays", "44332211", 44000m);
			customer1.AddAccount(bankaccount4);

			Console.WriteLine("Welcome");
			Console.WriteLine("The customer is:");
			Console.WriteLine(customer1.Fullname);
			Console.WriteLine("Accounts");
			Console.WriteLine("----------------------------");
			List<IAccount> accounts = customer1.Accounts();
			for (int i = 0; i < accounts.Count; i++)
			{
				BankAccount nextAccount = (BankAccount)accounts[i];
				Console.WriteLine(nextAccount.Bankname + " " + nextAccount.Balance.ToString());
			}

			Console.WriteLine("Now moving some money");
			bankaccount4.Transfer(bankaccount1, 100.34m);
			bankaccount2.Transfer(bankaccount3, 25.12m);

			Console.WriteLine("Accounts new balance");
			Console.WriteLine("----------------------------");

			for (int i = 0; i < accounts.Count; i++)
			{
				BankAccount nextAccount = (BankAccount)accounts[i];
				Console.WriteLine(nextAccount.Bankname + " " + nextAccount.Balance.ToString());
			}


		}
	}
}
