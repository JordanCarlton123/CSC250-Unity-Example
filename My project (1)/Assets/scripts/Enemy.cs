using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy
{
    private Room currentRoom;

    public enemy()
    {
        this.currentRoom = null;
    }

    public void setRoom(Room r)
    {
        this.currentRoom = r;
    }
}