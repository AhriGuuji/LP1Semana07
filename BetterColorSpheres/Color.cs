public class Color
        {
            private readonly byte red { get;} //Can be auto-implemented
            private readonly byte green; { get;} //Can be auto-implemented
            private readonly byte blue; { get;} //Can be auto-implemented
            private readonly byte alpha; { get;} //Can be auto-implemented

            public Color(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
                alpha = byte.Parse("255");
            }

            public byte GetGray() => (byte)((Red + Green + Blue) / 3);
        }