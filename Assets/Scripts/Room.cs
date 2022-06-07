using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
	[HideInInspector] public Door[] doors;
	
	void Awake()
	{
		doors = GetComponentsInChildren<Door>();
		
		
		Debug.Log("Awake room " + this.name + " with doors= "+ doors.Length);
	}
}
