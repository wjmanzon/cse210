using System.Collections.Generic;

public class House
{
    private Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    public void AddRoom(Room room)
    {
        rooms[room.Name] = room;
    }

    // Additional methods
}
