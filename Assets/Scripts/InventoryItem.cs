using System;
using UnityEngine;

[Serializable]
public struct InventoryItem
{
	public string id;
	public string name;
	[TextArea] public string description;
	public Sprite icon;
	public GameObject prefab;
	public GameObject reference;
}
