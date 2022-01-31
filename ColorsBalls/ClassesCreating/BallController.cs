using System;

namespace ColorsBalls
{
    public static class BallController
    {
        public static void BallPlaying()
        {
            Color ballColor = new Color(28, 123, 255);
            Console.WriteLine("Greyscale: " + ballColor.GetGreyscale());
            var col = new Color() {Red = 0, Blue = 12, Green = 88, Alpha = 2};
            
            Ball ball = new Ball(12, ballColor);
            ball.Throw();
            ball.Pop();
            ball.Throw();
            
            Ball ball1 = new Ball(12, col);
            //ball1.Pop();
            ball1.Throw();
            ball1.Throw();
            Console.WriteLine("ThrowCount ball1 : " + ball1.GetThrowCount());
            Console.WriteLine("Greyscale ball1 : " + ball1.Color.GetGreyscale());
            
            Ball ball2 = new Ball(12, ballColor);
            ball2.Pop();
            ball2.Throw();
            ball2.Throw();
            Console.WriteLine("ThrowCount ball2 : " + ball2.GetThrowCount());

            Console.WriteLine("ThrowCount: " + ball.GetThrowCount());
        }
    }
}