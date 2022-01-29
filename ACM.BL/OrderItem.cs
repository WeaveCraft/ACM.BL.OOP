namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemID)
        {
            OrderItemId = orderItemID;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        //Retrieve one order item.

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        //Saves the current order item.
        public bool Save()
        {
            return true;
        }

        //Validates the order item data.
        public bool Validate()
        {
            bool isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid |= false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
