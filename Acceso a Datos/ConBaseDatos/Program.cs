
using ConsoleApp6;

Console.WriteLine("Acceso a Datos!");

// Paso a paso para conectar con la base de datos en C# usando SqlClient:
//1 - Conexion
// 1. Definir el string de conexión (connection string)
var connectionString = "Data Source=.;Initial Catalog=Clinica;Integrated Security=true;TrustServerCertificate=True;";

// 2. Crear una instancia de SqlConnection usando el string de conexión
var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
//2 - Comando
var query = "SELECT MateriaId, Nombre FROM Materia WHERE Nombre LIKE '%status2%'";
var command = new Microsoft.Data.SqlClient.SqlCommand();
command.Connection = conn;
command.CommandText = query;
command.CommandType = System.Data.CommandType.Text;

// 3. Abrir la conexión
conn.Open();
Console.WriteLine("Conexión abierta!");

// ... aquí puedes ejecutar comandos SQL ...
//3 - DataReader
var reader = command.ExecuteReader();

var materias = new List<Materia>();

while (reader.Read())
{
    var materiaId = reader.GetInt32(0);
    var nombre = reader.GetString(1);

    materias.Add(new Materia
    {
        MateriaId = materiaId,
        Nombre = nombre
    });

    //Console.WriteLine($"MateriaId: {materiaId}, Nombre: {nombre}");
}



// 4. Cerrar la conexión cuando termines
conn.Close();
Console.WriteLine("Conexión cerrada!");