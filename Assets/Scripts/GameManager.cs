using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private Room startRoom;
	
	private Room current;
	
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("Start game:" + startRoom);
		
		ChangeCurrentRoom(startRoom);
	}
	
	private void ChangeCurrentRoom(Room destination)
	{
		if(current)
		{
			RemoveRoomEventCallbacks(current);
			current.ExitRoom();
		}
		
		AddRoomEventCallbacks(destination);
		destination.ViewRoom();
		current = destination;
	}
	
	private void AddRoomEventCallbacks(Room room)
	{
		foreach(Door door in room.doors) door.OnChangeRoom += ChangeRoomCallback;
		foreach(Item item in room.items) item.OnPickupItem += PickupItemCallback;
	}
	
	private void RemoveRoomEventCallbacks(Room room)
	{
		foreach(Door door in room.doors) door.OnChangeRoom -= ChangeRoomCallback;
		foreach(Item item in room.items) item.OnPickupItem -= PickupItemCallback;
	}
	
	private void ChangeRoomCallback(Room destination)
	{
		Debug.Log("Change current room to: " + destination.name);
		ChangeCurrentRoom(destination);
	}
	
	private void PickupItemCallback(Item item)
	{
		Debug.Log("Pickup item: " + item.name);
		
	}
}
