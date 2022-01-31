namespace ColorsBalls
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha = 255;

        public Color(int red, int green, int blue, int alpha)
        {
            this.Red = red;
            this.Blue = blue;
            this.Green = green;
            this.Alpha = alpha;
        }
        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Blue = blue;
            this.Green=green;
        }
        public Color(){}

        public int Red
        {
            get => red;
            set
            {
                red = value;
                if (red < 0) red = 0;
                if (red > 255) red = 255;
            }
        }
        
        public int Green
        {
            get => green;
            set
            {
                green = value;
                if (green < 0) green = 0;
                if (green > 255) green = 255;
            }
        }
        
        public int Blue
        {
            get => blue;
            set
            {
                blue = value;
                if (blue < 0) blue = 0;
                if (blue > 255) blue = 255;
            }
        }

        public int Alpha
        {
            get => alpha;
            set
            {
                alpha = value;
                if (alpha<0) alpha = 0;
                if (alpha>255) alpha = 255;
            }
        }

        public int GetGreyscale()
        {
            int greyscale = (red + green + blue) / 3;
            return greyscale;
        }
    }
}