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