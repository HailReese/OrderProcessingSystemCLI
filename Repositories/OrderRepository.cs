namespace OrderProcessingSystemCLI.Repositories;

using OrderProcessingSystemCLI.Models;

/// <summary>
/// Simulates a Data Access Layer (DAL)
/// Acts as an in-memory database mock for orders
/// </summary>
public class OrderRepository
{
	private static readonly List<Order> _orders = new List<Order>
	{
		new Order(1, new Client("Sam", true), 100.0m, "Delivery"),
		new Order(2, new Client("Marry", false), 525.98m, "Takeaway"),
		new Order(3, null, 756.332m, "Takeaway")
	};
	/// <summary>
	/// Fetches an order by its unique identifier.
	/// Simulates network latency or a heavy database query execution
	/// </summary>
	public async Task<Order?> GetOrderById(int Id)
	{
		await Task.Delay(1000);
		return _orders.Find(o => o.Id == Id);
	}
}