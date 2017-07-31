using System;
using System.Collections.Generic;
namespace Banking
{
    public abstract class Person : IPerson
    {
        #region Constructors
        public Person(string firstName, string surname)
        {
            m_firstName = firstName;
            m_surname = surname;
        }
        #endregion
        #region Member Variables
        private string m_firstName;
        private string m_surname;
        private List<IAccount> accounts = new List<IAccount>();
        #endregion
        #region IPerson Members
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
		public string Surname
		{
			get { return m_surname; }
			set { m_surname = value; }
		}
        public string Fullname
        {
            get { return m_firstName + " " + m_surname; }
        }
        public void AddAccount(IAccount account)
        {
            accounts.Add(account);
        }
        public List<IAccount> Accounts()
        {
            return accounts;
        }
        #endregion
    }
}
