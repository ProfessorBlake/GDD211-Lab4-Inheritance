using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffBaseClass : MonoBehaviour
{
	public virtual void Touched(ExamplePlayer player)
	{
		Destroy(gameObject);
	}
}
