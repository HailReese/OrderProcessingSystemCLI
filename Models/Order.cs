namespace OrderProcessingSystemCLI.Models;

public record Order(int Id, Client? Client, decimal TotalSum, string DeliveryType);