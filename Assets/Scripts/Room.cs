using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;
using Things;

public class Room : MonoBehaviour
{
	[SerializeField] private Camera cameraObject;
	
	[HideInInspector] public Door[] doors;
	[HideInInspector] public PickupEvent[] items;
	
	void Awake()
	{
		doors = GetComponentsInChildren<Door>();
		items = GetComponentsInChildren<PickupEvent>();
		
		Debug.Log("Awake room " + this.name + " with doors= "+ doors.Length);
	}
	
	public void ViewRoom()
	{
		cameraObject.enabled = true;
	}
	
	public void ExitRoom()
	{
		cameraObject.enabled = false;
	}
}
