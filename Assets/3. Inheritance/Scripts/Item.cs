using UnityEngine;

[System.Serializable] //This attribute allows the class to be displayed in the inspector.
public class Item
{
	public string Name;
	public int Cost;
	public float Damage;

	public void Use()
	{
		Debug.Log("Used " + Name);
		Cost -= 1;
	}
}