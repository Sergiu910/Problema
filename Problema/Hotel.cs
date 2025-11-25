namespace Problema;

public class Hotel
{   public List<Room> Rooms { get; set; } 
     public string Name { get; set; }
    public string Address { get; set; }

    public Hotel(string name, string adress,Room[] rooms)
    
    { Rooms = new List<Room>(rooms);
        Name = name;
        Address = adress;
        
    }
    
}