namespace BE_CRUDMASCOTAS.Models
{
    class Mascota
    {
        public int Id { get; set; }
        public String Raza { get; set; }
        public String Color { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
