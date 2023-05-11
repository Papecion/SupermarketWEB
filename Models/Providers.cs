namespace SupermarketWEB.Models
{
    public class Providers
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Complete_Name { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<PayMent>? PayMents { get; set; } = default!;

    }
}
