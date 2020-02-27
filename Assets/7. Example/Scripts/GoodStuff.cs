using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodStuff : StuffBaseClass
{
	public override void Touched(ExamplePlayer player)
	{
		player.Heal(1);
		base.Touched(player);
	}
}
