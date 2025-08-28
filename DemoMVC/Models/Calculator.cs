namespace DemoMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Hàm tính tổng tiền
        public double GetTotal()
        {
            return Price * Quantity;
        }
    }
}
