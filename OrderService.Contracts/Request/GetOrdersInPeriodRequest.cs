namespace OrderService.Contracts.Request;

public class GetOrdersInPeriodRequest
{
    public DateTime End { get; set; }
    
    public int Period { get; set; }
}