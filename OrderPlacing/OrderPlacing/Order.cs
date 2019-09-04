namespace FunctionApp1
{
    public class Order
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }

        public string Number { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
    }
}
