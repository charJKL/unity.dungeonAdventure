using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverHighlight : MonoBehaviour
{
	[SerializeField] private MeshRenderer mesh;
	[SerializeField] private Material defaultMaterial;
	[SerializeField] private Material hoverMaterial;
	
	private void OnMouseEnter()
	{
		mesh.material = hoverMaterial;
	}
	
	private void OnMouseExit()
	{
		mesh.material = defaultMaterial;
	}
}
