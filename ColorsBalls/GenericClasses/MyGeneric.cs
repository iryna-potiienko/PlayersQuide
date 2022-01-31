using System;

namespace ColorsBalls.GenericClasses
{
    public class MyGeneric<T> where T: new()
    {
        public string MakeString(T item)
        {
            var mystring = item.ToString();
            return mystring;
        }

        public void LoadObject<TMy> (string filename) where TMy: new()
        {
            var item = new TMy();
            Console.WriteLine("Object of class " + item.GetType() + " loaded from " + filename);
        }
    }
}