using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	[SerializeField] private MeshRenderer mesh;	
	[SerializeField] private Material defaultMaterial;
	[SerializeField] private Material hoverMaterial;
	[SerializeField] private Room destination;
	
	public delegate void ChangeRoom(Room destination);
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
		if(OnChangeRoom != null)
		{
			OnChangeRoom(destination);
		}
	}
}
