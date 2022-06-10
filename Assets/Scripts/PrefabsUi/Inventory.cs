using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prefabs;

namespace PrefabsUi
{
	public class Inventory : MonoBehaviour
	{
		[HideInInspector] private Transform box;
		[HideInInspector] private GameObject slotPrefab;
		
		private void Awake()
		{
			box = transform.Find("InventoryBox");
		}
		
		public void RedrawInventory(List<Item> items)
		{
			items.ForEach(InstantiateItemInSlot);
		}
		
		private void InstantiateItemInSlot(Item item)
		{
			GameObject slot = Instantiate(slotPrefab, box);
			slot.GetComponent<InventorySlot>().item = item;
		}
	}
}