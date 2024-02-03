using MiembroDeLaComunidad.Empleado;
using MiembroDeLaComunidad.ExAlumno;
using MiembroDeLaComunidad.Student;

namespace tarea1
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateStudent();
            CreateExStudent();
            CreateMaestro();

        }
        public static void CreateStudent()
        {
            Student student1 = new Student();
            student1.FirstName = "Manuel";
            student1.LastName = "Monterrey";
            student1.Greeting();
        }

        public static void CreateExStudent()
        {
            ExAlumno Egresado1 = new ExAlumno();
            Egresado1.FirstName = "Mateo";
            Egresado1.LastName = "Johnson";
            Egresado1.Greeting();
        }

        public static void CreateMaestro()
        {   
            Maestro CreateMaestro = new Maestro();
            CreateMaestro.FirstName = "Marisol";
            CreateMaestro.LastName = "CAMILO";
            CreateMaestro.Greeting();
        }
    }
}
