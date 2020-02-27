using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInheritance : MonoBehaviour
{
	public List<Item> ItemList = new List<Item>();
	public Item EquipedItem;

	public void Start()
	{
		ItemList.Add(new Shield());
		ItemList.Add(new Sword());

		foreach(Item i in ItemList)
		{
			Debug.Log(i.Name + ": $" + i.Cost);
		}

		EquipedItem = ItemList[0];
	}

	private void Update()
	{
		//Reduce the cost of a random item by 1.
		if(Input.GetKeyDown(KeyCode.Space))
		{
			ItemList[Random.Range(0, ItemList.Count)].Use();
		}
	}

	public void HurtEnemy()
	{
		Enemy e = new SmallGoblin();

		e.Health -= 10 * ItemList[1].Damage;
	}
}
