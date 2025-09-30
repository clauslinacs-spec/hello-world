using static ConsoleAppClaudia_Soto.Medicos;

namespace ConsoleAppClaudia_Soto
{
    public class Cita
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; } = null!;
        public Medicos Medico { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
    }
}
