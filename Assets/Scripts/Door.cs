using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	
	
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("start dooor logic");
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	private void OnMouseEnter()
	{
		Debug.Log("mouse enter the door");
	}
	
	private void OnMouseDown()
	{
		Debug.Log("door was clicked" + this.name);
	}
	
	private void OnMouseExit()
	{
		Debug.Log("mouse leave door");
	}
}
