﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
	public override void OnMouseDown()
	{
		base.OnMouseDown();
		Debug.Log(Name + ": Meow!");
	}
}
