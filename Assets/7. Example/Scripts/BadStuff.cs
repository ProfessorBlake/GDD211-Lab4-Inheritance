using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadStuff : StuffBaseClass
{
	public override void Touched(ExamplePlayer player)
	{
		player.Damage(1);
		base.Touched(player);
	}
}
