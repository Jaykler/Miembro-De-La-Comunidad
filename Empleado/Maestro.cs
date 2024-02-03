

namespace MiembroDeLaComunidad.Empleado
{
    public class Maestro: Docente
    {

        public Maestro() { }
        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine(" Soy Maestro de Matemáticas");
            Console.WriteLine("*--------------------------*");
        }
    }
}
