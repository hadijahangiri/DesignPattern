using System;
using Xunit;

namespace FactoryMethod.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void Constructor_probably_assign_properties_correctly_for_normal_customer()
        {
            var customerName = "hadi jahangiri";
            var customer = Customer.NormalCustomer(customerName);

            Assert.Equal(customerName, customer.FullName);
            Assert.Equal(CustomerType.Normal, customer.CustomerType);
            Assert.Equal(0, customer.InitialScore);
        }

        [Fact]
        public void Constructor_probably_assign_properties_correctly_for_vip_customer()
        {
            var customerName = "hadi jahangiri";
            var customer = Customer.VipCustomer(customerName);

            Assert.Equal(customerName, customer.FullName);
            Assert.Equal(CustomerType.Vip, customer.CustomerType);
            Assert.Equal(1000, customer.InitialScore);
        }
    }
}
