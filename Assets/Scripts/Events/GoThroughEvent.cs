using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Things;
namespace Events
{
	public delegate void GoThrough(Room destination);
	
	public class GoThroughEvent : MonoBehaviour
	{
		public event GoThrough OnGoThrough;
		
		private void Awake()
		{
			var isDoor = gameObject.GetComponent<Door>() != null;
			if(isDoor == false)
			{
				Debug.LogError("You can't go through game object which is not `Door`.", gameObject);
			}
		}
		
		private void OnMouseDown()
		{
			Debug.Log("GoThroughEvent::OnMouseDown");
			if(OnGoThrough != null)
			{
				Debug.Log("GoThroughEvent::OnMouseDown>>" + gameObject.name);
				Room destination = GetComponent<Door>().destination;
				OnGoThrough.Invoke(destination);
			}
		}
	}
}