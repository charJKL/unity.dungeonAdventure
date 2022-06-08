using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void PickupItem(Item item);

public class Item : MonoBehaviour
{
	public event PickupItem OnPickupItem;
	
	private void OnMouseDown()
	{
		Debug.Log("Item::OnMouseDown");
		if(OnPickupItem != null)
		{
			Debug.Log("Item::OnMouseDown>>" + this.name);
			OnPickupItem.Invoke(this);
		}
	}
}
