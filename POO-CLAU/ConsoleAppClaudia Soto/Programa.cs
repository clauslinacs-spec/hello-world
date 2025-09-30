using ConsoleAppClaudia_Soto;
using static ConsoleAppClaudia_Soto.Clinica;
using static ConsoleAppClaudia_Soto.Medicos;
using static ConsoleAppClaudia_Soto.Paciente;
using static ConsoleAppClaudia_Soto.Cita;


internal class Program
{
    private static void Main(string[] args)
    {
        Clinica clinica = new Clinica();

        ConsoleAppClaudia_Soto.Paciente paciente = new Paciente
        {
            Id = 1,
            Nombre = "Juan",
            Apellido = "Pérez",
            FechaNacimiento = DateTime.Parse("1990-01-01"),
            Telefono = "123456789",
            Direccion = "Calle 123"
        };

        Medicos medico = new Medicos
        {
            Id = 1,
            Nombre = "Dr. Smith",
            Apellido = "Johnson",
            Especialidad = "Cardiología",
            Telefono = "987654321"
        };
        Cita cita = new Cita
        {
            Id = 1,
            Paciente = paciente,
            Medico = medico,
            Fecha = DateTime.Parse("2024-03-16"),
            Hora = "10:00"
        };

        clinica.AgregarPaciente(paciente);
        clinica.AgregarMedico(medico);
        clinica.AgregarCita(cita);

        Console.WriteLine("Paciente agregado: " + paciente.Nombre + " " + paciente.Apellido);
        Console.WriteLine("Médico agregado: " + medico.Nombre + " " + medico.Apellido);
        Console.WriteLine("Cita agregada para el paciente " + cita.Paciente.Nombre + " " + cita.Paciente.Apellido + " con el médico " + cita.Medico.Nombre + " " + cita.Medico.Apellido);
    }
}
