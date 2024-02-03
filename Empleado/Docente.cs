

namespace MiembroDeLaComunidad.Empleado
{
    public class Docente: Empleado
    {
        public Docente() { }

        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine(" Soy Maestro de Matemáticas");
            Console.WriteLine("*--------------------------*");
        }
    }
}
