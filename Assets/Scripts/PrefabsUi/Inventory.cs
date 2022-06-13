using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prefabs;

namespace PrefabsUi
{
	public class Inventory : MonoBehaviour
	{
		[SerializeField] private GameObject inventorySlot;
		
		[HideInInspector] private Transform box;
		
		private void Awake()
		{
			box = transform.Find("InventoryBox");
		}
		
		public void RedrawInventory(List<InventoryItem> items)
		{
			Debug.Log("works?");
			items.ForEach(InstantiateItemInSlot);
		}
		
		private void InstantiateItemInSlot(InventoryItem item)
		{
			GameObject slot = Instantiate(inventorySlot, box);
			slot.GetComponent<InventorySlot>().item = item;
		}
	}
}