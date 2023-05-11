namespace SupermarketWEB.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Complete_Name { get; set; }
        public int Code { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public ICollection<Invoice>? Invoices { get; set; } = default!;

    }
}
