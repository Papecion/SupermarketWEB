namespace SupermarketWEB.Models
{
    public class PayMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Method { get; set; }

        public ICollection<PayMent>? PayMents { get; set; } = default!;
    }
}
