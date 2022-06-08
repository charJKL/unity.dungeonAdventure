using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Things;
using Events;

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
			RemoveRoomEventListeners(current);
			current.ExitRoom();
		}
		
		AddRoomEventListeners(destination);
		destination.ViewRoom();
		current = destination;
	}
	
	private void AddRoomEventListeners(Room room)
	{
		foreach(GoThroughEvent door in room.doors) door.OnGoThrough += OnGoThroughListener;
		foreach(PickupEvent pickup in room.items) pickup.OnPickupItem += PickupItemListener;
	}
	
	private void RemoveRoomEventListeners(Room room)
	{
		foreach(GoThroughEvent door in room.doors) door.OnGoThrough -= OnGoThroughListener;
		foreach(PickupEvent pickup in room.items) pickup.OnPickupItem -= PickupItemListener;
	}
	
	private void OnGoThroughListener(Room destination)
	{
		Debug.Log("Change current room to: " + destination.name);
		ChangeCurrentRoom(destination);
	}
	
	private void PickupItemListener(Item item)
	{
		Debug.Log("You pickup: " + item.gameObject.name);
	}
	
}
