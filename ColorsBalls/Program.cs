using System;
using ColorsBalls.GenericClasses;

namespace ColorsBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            //BallController.BallPlaying();

            PracticeList<string> stringList = new PracticeList<string>();
            stringList.Add("string 1");
            stringList.Add("oo my");
            
            Console.WriteLine(stringList.GetItem(0));

            var color = new Color();
            MyGeneric<Color> item = new MyGeneric<Color>();
            Console.WriteLine(item.MakeString(color));
            
            item.LoadObject<float>("color.txt");
        }
    }
}