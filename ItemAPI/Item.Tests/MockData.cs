namespace Item.Tests
{
    public class MockData
    {
        public List<Domain.Models.Item> GetItems()
        {
            Random rnd = new Random();
            IEnumerable<Domain.Models.Item> items = Enumerable.Repeat(
                new Domain.Models.Item { Id = rnd.Next(1, 100), Manufacturer = "mfg1", Name = "Item1", Price = 0, Quantity = 1 }, 10);

            return items.ToList();
        }
    }
}