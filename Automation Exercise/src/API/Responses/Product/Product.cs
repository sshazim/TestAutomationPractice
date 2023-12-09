namespace TestAutomationPractice.src.API.Responses
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }
        public CategoryDetails Category { get; set; }
    }
}