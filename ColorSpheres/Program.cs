using System;

namespace ColorSpheres
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Color purple = new Color(255,0,255);

            Sphere bola = new Sphere(purple,20);

            bola.Throw();
            bola.Throw();
            bola.Throw();

            Console.WriteLine(purple);
            Console.WriteLine(bola.GetTimesThrown());
        }
    }
}
