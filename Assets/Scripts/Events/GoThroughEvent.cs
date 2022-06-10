using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prefabs;

namespace Events
{
	public delegate void GoThrough(Room destination);
	
	[RequireComponent(typeof(Door))]
	public class GoThroughEvent : MonoBehaviour
	{
		public event GoThrough OnGoThrough;
		
		private void OnMouseDown()
		{
			Debug.Log($"GoThroughEvent::OnMouseDown.");
			if(OnGoThrough != null)
			{
				Debug.Log("GoThroughEvent::OnMouseDown>>" + gameObject.name);
				Room destination = GetComponent<Door>().destination;
				OnGoThrough.Invoke(destination);
			}
		}
	}
}