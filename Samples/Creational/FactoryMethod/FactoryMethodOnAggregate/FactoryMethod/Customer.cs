using System;

namespace FactoryMethod
{
    public class Customer
    {
        public string FullName { get; private set; }
        public int InitialScore { get;private set; }
        public CustomerType CustomerType { get; private set; }

        private Customer(string fullName, int initialScore, CustomerType customerType)
        {
            FullName = fullName;
            InitialScore = initialScore;
            CustomerType = customerType;
        }

        public static Customer NormalCustomer(string fullName)
        {
            return new Customer(fullName, 0, CustomerType.Normal);
        }

        public static Customer VipCustomer(string fullName)
        {
            return new Customer(fullName, 1000, CustomerType.Vip);
        }

    }
}
