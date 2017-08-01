
using System;
namespace Banking
{
    /// <summary>
    /// Account. Abstract class that implements the IAccount interface
    /// </summary>
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
        public void Deposit(decimal value)
        {
            m_balance += value;
        }
        public void Withdraw(decimal value)
        {
            m_balance -= value;
        }
        public void Transfer(IAccount account, decimal value)
        {
            decimal curBalance = m_balance;
            try
            {
                account.Deposit(value);
                Withdraw(value);
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
