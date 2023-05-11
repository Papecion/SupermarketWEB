namespace SupermarketWEB.Models
{
    public class Information
    {
        public int Id { get; set; }
        public int PayMentId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public ICollection<PayMent>? PayMents { get; set; } = default!;
    }
}
