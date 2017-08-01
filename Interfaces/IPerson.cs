using System;
using System.Collections.Generic;
namespace Banking
{
	public interface IPerson
	{
		string FirstName { get; set; }
		string Surname { get; set; }
		string Fullname { get; }
		void AddAccount(IAccount account);
		List<IAccount> Accounts();
	}
}