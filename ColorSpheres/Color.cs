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