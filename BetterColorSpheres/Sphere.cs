public class Sphere
        {
            private readonly Color mask;
            private float radius;
            private int launchTimes;

            public Sphere(Color mask, float radius)
            {
                this.mask = mask; 
                this.radius = radius;
                launchTimes = 0;
            }

            // This method set radius to zero
            public void Pop()
            {
                radius = 0;
            }

            // This method add one to how many times you throwed
            public void Throw()
            {
                if (radius > 0)
                {
                    launchTimes++;
                }
            }

            // This method get how many times you throwed
            public int GetTimesThrown()
            {
                return launchTimes;
            }
        }