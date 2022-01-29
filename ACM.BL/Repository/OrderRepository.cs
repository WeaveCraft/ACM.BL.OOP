using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            //Create the instance of the Order class.
            //Pass in the requested Id.
            Order order = new Order();

            //Code that retrieves the defined order.

            //Temporary hard-coded values to return a populated order.
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new System.TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save(Order order)
        {
            //Code that saves the pased in order

            return true;
        }
    }
}
