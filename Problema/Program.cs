using System.Diagnostics.Contracts;

namespace Problema;

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>()
        {
            new Room.Standard(101, true,100),
            new Room.Suite(201, true, 190,"Ocean View, Jacuzzi")
        };
        Hotel hotel = new Hotel("Grand Hotel", "123 Main St", rooms.ToArray());


        Console.WriteLine($"Hotel Name: {hotel.Name}");
        Console.WriteLine($"Hotel Address: {hotel.Address}");
        foreach (var ra in rooms)
        {
            Console.WriteLine(ra.ToString());
        }
    }
}