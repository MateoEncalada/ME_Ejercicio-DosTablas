namespace ME_Ejercicio_DosTablas.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public int Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }

        public int BurgerId { get; set; }
        public Burger? Burger { get; set; }
    }
}
