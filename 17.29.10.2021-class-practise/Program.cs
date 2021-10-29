using System;

namespace _17._29._10._2021_class_practise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor
            //Student student1 = new Student();
            #endregion

            #region Home class
            //Home[] homeList = new Home[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Home newHomeItem = new Home
            //    {
            //        roomCount = (byte)(i + 2),
            //        floorCount = (byte)(i + 1),
            //        city = "City " + i,
            //        address = "Address " + i,
            //        phoneNumber = new String((char)(48 + i), 10)
            //    };
            //    homeList[i] = newHomeItem;
            //}
            //Console.WriteLine("Full info:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Home {0} Info => ", i);
            //    homeList[i].getFullInfo();
            //}
            //Console.WriteLine("\nCities:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Home {0} => City: {1}", i, homeList[i].city);
            //}
            #endregion

            #region Math clone
            MyMath myMath = new MyMath();
            Console.WriteLine("2^4 = " + myMath.Pow(2, 4));
            Console.WriteLine("4.0^2.0 = " + myMath.Pow(4.0, 2.0));
            #endregion
        }
    }
}
