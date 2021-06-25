using System;

namespace Payment.Domain
{
    public class Order
    {
        public int Id { get; private set; }
        public DateTime ExpireDate { get;private set; }

        public Order(int id, DateTime expireDate)
        {
            Id = id;
            ExpireDate = expireDate;
        }

        public Payment Payed(int value)
        {
            if (this.ExpireDate < DateTime.Now)
                throw new Exception("Order is invalid");

            return new Payment(value, this.Id);
        }
    }
}