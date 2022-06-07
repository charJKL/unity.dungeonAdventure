using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
	[SerializeField] private Camera cameraObject;
	
	[HideInInspector] public Door[] doors;
	
	void Awake()
	{
		doors = GetComponentsInChildren<Door>();
		
		
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
