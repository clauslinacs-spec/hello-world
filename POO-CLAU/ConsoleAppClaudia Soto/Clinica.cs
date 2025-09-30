using static ConsoleAppClaudia_Soto.Paciente;
using static ConsoleAppClaudia_Soto.Medicos;
namespace ConsoleAppClaudia_Soto
{
    
        public class Clinica
        {
            public List<Paciente> Pacientes { get; set; }
            public List<Medicos> Medicos { get; set; }
            public List<Cita> Citas { get; set; }

            public Clinica()
            {
                Pacientes = new List<Paciente>();
                Medicos = new List<Medicos>();
                Citas = new List<Cita>();
            }

            public void AgregarPaciente(Paciente paciente)
            {
                Pacientes.Add(paciente);
            }

            public void AgregarMedico(Medicos medico)
            {
                Medicos.Add(medico);
            }

            public void AgregarCita(Cita cita)
            {
                Citas.Add(cita);
            }
        }
    }

