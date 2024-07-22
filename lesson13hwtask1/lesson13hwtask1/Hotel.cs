using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13hwtask1
{
    public class Hotel
    {
        public string Name;
        private Room[] rooms = Array.Empty<Room>();
        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms,rooms.Length+1);
            rooms[rooms.Length-1] = room;
            Console.WriteLine($"{room.Name} aded");

        }
        public Hotel(string name)
        {
            Name = name;
        }
        public void MakeReservation(int? id)
        {
            if(id == null) throw new NullReferenceException("id is null");

            foreach(var room in rooms)
            {
                if(room.Id==id)
                {
                    if (room.IsAvibale == false)
                    {
                        throw new NotAviableExeption("the room is not aviable");
                    }
                    room.IsAvibale = false;
                    Console.WriteLine("room reserved");
                }
            }

        }

        

    }
}
