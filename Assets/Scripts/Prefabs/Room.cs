using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

namespace Prefabs
{
	public class Room : MonoBehaviour
	{
		[SerializeField] private Camera cameraObject;
		
		[HideInInspector] public GoThroughEvent[] doors;
		[HideInInspector] public PickupEvent[] items;
		
		private void Awake()
		{
			doors = GetComponentsInChildren<GoThroughEvent>();
			items = GetComponentsInChildren<PickupEvent>();
			
			Debug.Log($"Awake room {this.name} with doors={doors.Length}, items={items.Length}.");
		}
		
		public void EnterRoom()
		{
			cameraObject.enabled = true;
		}
		
		public void ExitRoom()
		{
			cameraObject.enabled = false;
		}
	}
}
