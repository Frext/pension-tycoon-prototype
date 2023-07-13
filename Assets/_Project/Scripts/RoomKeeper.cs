using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Project.Scripts
{
    [Serializable]
    public class Room
    {
        public Transform transform;
        public bool isBusy;
    }
    
    public class RoomKeeper : MonoBehaviour
    {
        public List<Room> roomsList;

        public Room GetRoom()
        {
            foreach (var room in roomsList)
            {
                if (!room.isBusy)
                {
                    room.isBusy = true;
                    
                    return room;
                }
            }

            return null;
        }

        public void LeaveRoom(Room room)
        {
            room.isBusy = false;
        }
        
        public bool IsThereAvailableRoom()
        {
            foreach (var room in roomsList)
            {
                if (!room.isBusy)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
