namespace OrderProcessingSystemCLI;

public record Order(int Id, Client? Client, decimal TotalSum, string DeliveryType);