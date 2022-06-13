using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prefabs;
using PrefabsUi;
using Events;

public class GameManager : MonoBehaviour
{
	[SerializeField] private Room startRoom;
	[SerializeField] private Inventory uiInventory;
	
	private List<InventoryItem> inventory;
	private Room current;
	
	private void Start()
	{
		Debug.Log($"Start game in: {startRoom}");
		inventory = new List<InventoryItem>();
		
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
		destination.EnterRoom();
		current = destination;
	}
	
	private void PickupItemIntoInventory(Item item)
	{
		InventoryItem inventoryItem = item.item;
		inventory.Add(inventoryItem);
		uiInventory.RedrawInventory(inventory);
		Debug.Log($"Items in inventory: {inventory}.");
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
		Debug.Log($"You pickup: {item.name}.");
		PickupItemIntoInventory(item);
	}
	
}
