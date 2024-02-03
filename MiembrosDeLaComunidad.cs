namespace MiembroDeLaComunidad
{
    public abstract class MiembroDeLaComunidad
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public virtual void Greeting()
        {
            Console.WriteLine();
            Console.WriteLine("Hola! Mi nombre es " + FullName);
        }
    }
}
