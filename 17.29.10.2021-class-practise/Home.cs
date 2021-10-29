using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_class_practise
{
    class Home
    {
        public byte roomCount { get; set; }
        public byte floorCount { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string city { get; set; }
        public void getFullInfo()
        {
            Console.WriteLine("rooms: {0}, floors: {1}, address: {2}, city: {3}, phoneNumber: {4}", roomCount, floorCount, address, city, phoneNumber);
        }
    }
}
