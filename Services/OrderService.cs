namespace OrderProcessingSystemCLI.Services;

using System.IO.Pipes;
using OrderProcessingSystemCLI.Models;
using OrderProcessingSystemCLI.Repositories;

public class OrderService
{
	private readonly OrderRepository _orderRepository = new();

	public Task<Order?> GetOrderDetailAsync(int Id)
	{
		return _orderRepository.GetOrderByIdAsync(Id);
	}

	public async Task<decimal> CalculateFinalPriceAsync(int Id)
	{
		Order? _order = await _orderRepository.GetOrderByIdAsync(Id);
		if (_order == null) { return 0m; }

		decimal discount = await Task.Run(() =>
		{
			return _order.Client switch
			{
				{ IsVip: true } => 0.15m,
				{ IsVip: false } when _order.TotalSum > 500m => 0.05m,
				null => 0m,
				_ => 0m
			};
		});

		return discount * _order.TotalSum;
	}
}