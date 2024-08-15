using OrderService.Contracts.ApiModels;

namespace OrderService.Contracts.Response;

public class GetOrdersInPeriodResponse
{
    public List<OrderApiFullModel> Orders { get; set; }
}