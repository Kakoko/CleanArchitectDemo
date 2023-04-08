namespace CleanArchitect.Demo.API.Models
{
    public class TransferMoneyDto
    {
        public int AccountIdFrom { get; set; }
        public int AccountIdTo { get; set; }
        public decimal Amount { get; set; }
    }
}
