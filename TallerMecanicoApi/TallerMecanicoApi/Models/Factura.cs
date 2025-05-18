namespace TallerMecanicoApi.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
    }
}
