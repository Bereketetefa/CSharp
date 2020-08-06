using System;
using System.Collections.Generic;


namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objList = new List<object>();
            {
                objList.Add(7);
                objList.Add(28);
                objList.Add(-1);
                objList.Add(true);
                objList.Add("chair");
                foreach (var obj in objList)
                Console.WriteLine(obj);
            }
                int sum = 0;
                    foreach (var obj in objList)
            {
                    if (obj is int)
                {
                    sum += (int)obj;
                }
            }
        Console.WriteLine(sum);
        }
    }
}
