using System.Text.Json;



namespace SerializationDemo
{
    public class Purchase
    {
        public string? ProductName { get; set; }
        public DateTime DateTime { get; set; }
        public decimal PurchasePrice { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Purchase purchase = new Purchase
            {
                ProductName = "Orange Juice",
                DateTime = DateTime.Now,
                PurchasePrice = 2.49m
            };

            // Serialization
            // dotnet object into JSON format

            string jsonString = JsonSerializer.Serialize(purchase);

            // Deserialization
            // JSON to C# object
            Purchase purchase1 = JsonSerializer.Deserialize<Purchase>(jsonString);
        }
    }
}