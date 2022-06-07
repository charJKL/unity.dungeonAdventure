using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ChangeRoom(Room destination);

public class Door : MonoBehaviour
{
	[SerializeField] private MeshRenderer mesh;
	[SerializeField] private Material defaultMaterial;
	[SerializeField] private Material hoverMaterial;
	[SerializeField] private Room destination;
	
	public event ChangeRoom OnChangeRoom;
	
	private void OnMouseEnter()
	{
		mesh.material = hoverMaterial;
	}
	
	private void OnMouseExit()
	{
		mesh.material = defaultMaterial;
	}
	
	private void OnMouseDown()
	{
		Debug.Log("Door::OnMouseDown");
		if(OnChangeRoom != null)
		{
			Debug.Log("Door::OnMouseDown>>" + destination.name);
			OnChangeRoom.Invoke(destination);
			mesh.material = defaultMaterial;
		}
	}
}
