using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prefabs;
using UnityEngine.UI;

namespace PrefabsUi
{
	public class InventorySlot : MonoBehaviour
	{
		private Image icon;
		
		private InventoryItem private_item;
		
		[HideInInspector] public InventoryItem item
		{
			set{ private_item = value; Redraw(); }
			get{ return private_item; }
		}
		
		private void Awake()
		{
			icon = transform.Find("Icon").GetComponent<Image>();
		}
		
		private void Redraw()
		{
			Debug.Log("item redraw");
			icon.sprite = private_item.icon;
		}
	}
}


