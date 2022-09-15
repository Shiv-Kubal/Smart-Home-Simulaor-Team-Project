using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveRoomDropdown : MonoBehaviour
{
    List<string> roomList = new List<string>();

    void getRoomList()
    {
        GameObject[] roomObjList = GameObject.FindGameObjectsWithTag("Room");
        for(int i = 0; i<roomObjList.Length; i++)
        {
            roomList.Add(roomObjList[i].name);
        }
    }

    public Dropdown moveDropDown;
    public Dropdown resizeDropDown;
    public Dropdown deleteDropDown;

    void Update()
    {
        getRoomList();
        populateDropDown();
    }

    void populateDropDown()
    {
        moveDropDown.AddOptions(roomList);
        resizeDropDown.AddOptions(roomList);
        deleteDropDown.AddOptions(roomList);
    }

    public void DropDown_IndexChanged(int index)
    {
        
    }
}
