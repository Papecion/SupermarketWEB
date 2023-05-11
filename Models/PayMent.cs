namespace SupermarketWEB.Models
{
    public class PayMent
    {
        public int Id { get; set; }
        public int Serial { get; set; }
        public int ProviderId { get; set; }
        public int PayModeId { get; set; }
        public DateTime Date { get; set; }

        public ICollection<PayMode>? PayModes { get; set; } = default!;
    }
}
