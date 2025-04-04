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

            Console.WriteLine(bola.GetTimesThrown());

        }
        public class Color
        {
            private byte red;
            private byte green;
            private byte blue;
            private byte alpha;

            public byte Red
            {
                get { return red; }
            }

            public byte Green
            {
                get { return green; }
            }

            public byte Blue
            {
                get { return blue; }
            }

            public byte Alpha
            {
                get { return alpha; }
            }

            public Color(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
                alpha = byte.Parse("255");
            }

            public byte GetGray()
            {
                {return (byte)((Red + Green + Blue) / 3); }
            }
        }

        public class Sphere
        {
            private Color mask;
            private float radius;
            private int launchTimes;

            public Sphere(Color mask, float radius)
            {
                this.mask = mask;
                this.radius = radius;
                launchTimes = 0;
            }

            public void Pop()
            {
                radius = 0;
            }

            public void Throw()
            {
                if (radius > 0)
                {
                    launchTimes++;
                }
            }

            public int GetTimesThrown()
            {
                return launchTimes;
            }
        }
    }
}
