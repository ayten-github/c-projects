using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13hwtask1
{
    public class Room
    {
        private static int _id;
        public int Id {get; set;}
        public string Name {get; set;}
        public double Price { get; set;}
        public int PersonCapacity { get; set; }
        public bool IsAvibale { get ; set; }
        public Room(string name,int capacity,double price) {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = capacity;
        }
        public static string ShowInfo(Room room) {
            return $"name{room.Name}price{room.PersonCapacity}price{room.Price}";
                }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
