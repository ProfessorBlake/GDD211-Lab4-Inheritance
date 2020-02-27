using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Orc : Enemy
{
	public float AvoidChance;

	public override void TakeDamage(float dmg)
	{
		if(Random.value < AvoidChance)
		{
			Debug.Log(Name + " avoided attack!");
		}
		else
		{
			Health -= dmg;
			Debug.Log(Name + " took " + dmg + " damage");
		}
	}
}
