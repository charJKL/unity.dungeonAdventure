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
			RemoveOnChangeRoomListeners(current.doors);
			current.ExitRoom();
		}
		
		//destination.gameObject.SetActive(true);
		AddOnChangeRoomListeners(destination.doors);
		destination.ViewRoom();
		current = destination;
	}
	
	private void AddOnChangeRoomListeners(Door[] doors)
	{
		foreach(Door door in doors) door.OnChangeRoom += ChangeRoom;
	}
	
	private void RemoveOnChangeRoomListeners(Door[] doors)
	{
		foreach(Door door in doors) door.OnChangeRoom -= ChangeRoom;
	}
	
	public void ChangeRoom(Room destination)
	{
		Debug.Log("Change current room to" + destination.name);
		ChangeCurrentRoom(destination);
	}
	
}
