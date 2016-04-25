using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	private float _speed;

	void Start()
	{
		Destroy (gameObject, 2f);
	}

	void Update () 
	{
		transform.Translate (Vector3.forward * _speed * Time.deltaTime);
	}

	public void setSpeed(float value)
	{
		_speed = value;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Enemy1")) 
		{	
			EnemyHealth enemyHealth = other.GetComponent<EnemyHealth> ();
			if (enemyHealth != null) 
			{
				enemyHealth.TakeDamage1 (5);
			}
			Destroy (gameObject);
		}

		if (other.CompareTag ("Enemy2")) 
		{
			EnemyHealth enemyHealth = other.GetComponent<EnemyHealth> ();
			if (enemyHealth != null) 
			{
				enemyHealth.TakeDamage2 (5);
			}
			Destroy (gameObject);
		}

		if (other.CompareTag ("Enemy3")) 
		{
			EnemyHealth enemyHealth = other.GetComponent<EnemyHealth> ();
			if (enemyHealth != null) 
			{
				enemyHealth.TakeDamage3 (5);
			}
			Destroy (gameObject);
		}

		if (other.CompareTag ("Wall")) 
		{
			Destroy (gameObject);
		}
	}
}
