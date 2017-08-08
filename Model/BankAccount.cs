using System;
namespace Banking
{
	[Serializable]
    public class BankAccount : Account
    {
        #region Constructor
        public BankAccount(string bank, string accountNumber, decimal balance) : base(accountNumber, balance)
        {
            Bankname = bank;
        }
        #endregion
        #region Member Variables
        private string m_bank;
        #endregion
        #region Bank Account Members
        public string Bankname
        {
            get { return m_bank; }
            set { m_bank = value; }
        }
        #endregion
    }
}
