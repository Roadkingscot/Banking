
using System;
using System.Collections.Generic;
namespace Banking
{
    /// <summary>
    /// Account. Abstract class that implements the IAccount interface
    /// </summary>
    [Serializable]
    public abstract class Account : IAccount
    {
        #region Constuctors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BankingApp.Model.Account"/> class.
        /// </summary>
        public Account(string accountNumber, decimal balance)
        {
            m_accountNumber = accountNumber;
            m_balance = balance;
        }
        #endregion

        #region Member Variables
        private string m_accountNumber;
        private decimal m_balance;
        private IPerson m_customer;
        private List<ITransaction> m_transactions = new List<ITransaction>();

        #endregion

        #region IAccount Members
        public string AccountHolder
        {
            get { return m_customer.Fullname; }
        }
        public decimal Balance
        {
            get { return m_balance; }
        }
        public List<ITransaction> Transactions
        {
            get { return m_transactions; }
        }
        public void Deposit(decimal value)
        {
            m_balance += value;
            //Now add a transaction
            m_transactions.Add(new Transaction(m_accountNumber, "C", value, 0, m_balance));
        }
        public void Withdraw(decimal value)
        {
            if (value <= m_balance)
            {
                m_balance -= value;
				//Now add a transaction
				m_transactions.Add(new Transaction(m_accountNumber, "D", 0, value, m_balance));
            }
            else
            {
                throw new InsufficientFundsException("Account " + m_accountNumber +
                                                     " has insuffient funds. Funds available = " + m_balance + "funds requested= " + value);
            }
        }
        public void Transfer(IAccount account, decimal value)
        {
            decimal curBalance = m_balance;
            try
            {
				Withdraw(value);
                account.Deposit(value);
                return;
            }
            catch (Exception ex)
            {
                if (Decimal.Compare(curBalance, m_balance) != 0) { m_balance = curBalance; }
                throw ex;
            }
        }
        public void AddAccountHolder(IPerson customer)
        {
            m_customer = customer;
        }
        #endregion
    }
}
