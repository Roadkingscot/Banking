using System;
namespace Banking
{
	[Serializable]
    public class Customer : Person
    {
        public Customer(string firstName, string surname):base(firstName,surname)
        {
        }
    }
}
