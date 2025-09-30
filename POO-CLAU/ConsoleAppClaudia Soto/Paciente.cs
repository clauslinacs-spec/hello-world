namespace ConsoleAppClaudia_Soto
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}