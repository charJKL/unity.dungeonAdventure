using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Things
{
	public class Door : MonoBehaviour
	{
		[SerializeField] public Room destination;
		
		void OnDrawGizmos()
		{
			// Draw door destination:
			if(destination != null)
			{
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(transform.position, destination.transform.position);
			}
		}
	}
}