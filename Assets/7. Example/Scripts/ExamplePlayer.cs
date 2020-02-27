using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePlayer : MonoBehaviour
{
	public float WalkSpeed;
	public Transform HealthPool;
	public GameObject HealthIconPrefab;
	public GameObject EnemyPrefab;
	public GameObject PotionPrefab;

	private int hp;

	private void Start()
	{
		hp = Random.Range(1, 4);

		for(int i = 0; i < Random.Range(3,6); i++)
		{
			Instantiate(EnemyPrefab, Random.insideUnitCircle * Random.Range(4f,8f), Quaternion.identity);
			Instantiate(PotionPrefab, Random.insideUnitCircle * Random.Range(4f, 8f), Quaternion.identity);
		}
	}

	private void Update()
	{
		Vector3 moveVec = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		transform.position += moveVec * (Time.deltaTime * WalkSpeed);

		UpdateHealthPool();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		StuffBaseClass hitStuff = collision.GetComponent<StuffBaseClass>();
		
		if(hitStuff)
		{
			hitStuff.Touched(this);
		}
	}

	public void Damage(int amnt)
	{
		hp -= amnt;

		if (hp <= 0)
			Destroy(gameObject);
	}

	public void Heal(int amnt)
	{
		hp += amnt;
	}

	private void UpdateHealthPool()
	{
		if (HealthPool.childCount > hp)
		{
			Destroy(HealthPool.GetChild(0).gameObject);
		}
		else if(HealthPool.childCount < hp)
		{
			Instantiate(HealthIconPrefab, HealthPool);
		}
	}
}
