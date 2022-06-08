using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ChangeRoom(Room destination);

public class Door : MonoBehaviour
{
	[SerializeField] private Room destination;
	
	public event ChangeRoom OnChangeRoom;
	
	private void OnMouseDown()
	{
		Debug.Log("Door::OnMouseDown");
		if(OnChangeRoom != null)
		{
			Debug.Log("Door::OnMouseDown>>" + destination.name);
			OnChangeRoom.Invoke(destination);
		}
	}
}
