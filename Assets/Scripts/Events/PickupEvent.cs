using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prefabs;

namespace Events
{
	public delegate void Pickup(Item item);
	
	[RequireComponent(typeof(Item))]
	public class PickupEvent : MonoBehaviour
	{
		public event Pickup OnPickupItem;
		
		private void OnMouseDown()
		{
			Debug.Log("PickupEvent::OnMouseDown");
			if(OnPickupItem != null)
			{
				Debug.Log("PickupEvent::OnMouseDown>>" + this.gameObject.name);
				Item item = gameObject.GetComponent<Item>();
				OnPickupItem.Invoke(item);
				Destroy(gameObject);
			}
		}
	}
}