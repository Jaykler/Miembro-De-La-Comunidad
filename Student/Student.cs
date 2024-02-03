

namespace MiembroDeLaComunidad.Student
{
    public class Student : MiembroDeLaComunidad
    {

        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("  Soy estudiante Estudiante");
            Console.WriteLine("*--------------------------*");
        }
    }
}
