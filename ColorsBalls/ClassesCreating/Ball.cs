namespace ColorsBalls
{
    public class Ball
    {
        private int size;
        private int throwCount;
        
        public int Size
        {
            get => size;
            set
            {
                size = value;
                if (size < 0) size = 0;
            }
        }

        public Color Color { get; set; }

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
        }
        
        public Ball(int size)
        {
            Size = size;
        }
        
        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size!=0)
                throwCount++;
        }

        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}