using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Things;

namespace Events
{
	public delegate void Pickup(Item item);
	
	public class PickupEvent : MonoBehaviour
	{
		public event Pickup OnPickupItem;
		
		public void Awake()
		{
			var isItem = gameObject.GetComponent<Item>() != null;
			if(isItem == false)
			{
				Debug.LogError("You can'y pickup game object which is not `Item`.", gameObject);
			}
		}
		
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