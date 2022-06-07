using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
	[HideInInspector] public Door[] doors;
	
	void Start()
	{
		doors = GetComponentsInChildren<Door>();
	}
}
