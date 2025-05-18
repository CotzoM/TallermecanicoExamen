namespace TallerMecanicoApi.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Servicio { get; set; }
    }
}
