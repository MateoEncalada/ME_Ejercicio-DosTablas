namespace ME_Ejercicio_DosTablas.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        public int Name { get; set; }
        public int WithCheese { get; set; }

        public List<Promo>? Promos { get; set;}
    }
}
