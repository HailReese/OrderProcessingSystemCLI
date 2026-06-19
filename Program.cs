using OrderProcessingSystemCLI.Services;
using OrderProcessingSystemCLI.Models;

var orderService = new OrderService();

System.Console.WriteLine(await orderService.CalculateFinalPriceAsync(1));
System.Console.WriteLine(await orderService.CalculateFinalPriceAsync(3));