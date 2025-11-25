namespace Problema;

public class Room
{
    public int RoomNumber { get; set; }
    public int Price { get; set; }
    public bool IsAvailable { get; set; }

    public Room(int roomNumber, bool isAvailable, int price)
    {
        RoomNumber = roomNumber;
        IsAvailable = isAvailable;
        Price = price;
    }

    public override string ToString()
    {
        return $"{RoomNumber} +{Price}+{IsAvailable}";
    }

    public void faaa()
    {
        int a = RoomNumber * 2;

        Console.WriteLine(a);
    }

    public class Standard : Room

    {
        public Standard(int roomNumber, bool isAvailable, int price)
            : base(roomNumber, isAvailable, price)

        {

        }

        public void CheckAvailability()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"Standard Room {RoomNumber} is available.");
            }
            else
            {
                Console.WriteLine($"Standard Room {RoomNumber} is not available.");
            }
        }

        public override string ToString() => $"{RoomNumber} +{Price}+{IsAvailable}";

    }

    public class Suite : Room
    {
        public string Extras { get; set; }

        public Suite(int roomNumber, bool isAvailable, int price, string extras) : base(roomNumber, isAvailable, price)
        {
            Extras = extras;
        }

        public void CheckAvailability()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"Suite Room {RoomNumber} is available.");

            }
            else
            {
                Console.WriteLine($"Suite Room {RoomNumber} is not available.");
            }
        }

        public override string ToString()
        {
            return $"{RoomNumber} +{Price}+{IsAvailable}";
        }



    }
    
    public void tarif()
    {
        int price2 = Price * 60 / 100;
        Console.WriteLine($"The price for the suite room {RoomNumber} after discount is: {price2}");
    }
}