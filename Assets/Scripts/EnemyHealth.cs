using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	float _EnemyHealth1 = 10;
	float _EnemyHealth2 = 20;
	float _EnemyHealth3 = 250;

	public void TakeDamage1(float dmg)
	{
		_EnemyHealth1 -= dmg;
		if (_EnemyHealth1 <= 0) 
		{
			Score score = GameObject.FindObjectOfType<Score> ();
			score.SetScore (5);
			Destroy (gameObject);
		}
	}

	public void TakeDamage2(float dmg)
	{ 
		_EnemyHealth2 -= dmg;
		if (_EnemyHealth2 <= 0) 
		{
			Score score = GameObject.FindObjectOfType<Score> ();
			score.SetScore (10);
			Destroy (gameObject);
		}
	}

	public void TakeDamage3(float dmg)
	{ 
		_EnemyHealth3 -= dmg;
		if (_EnemyHealth3 <= 0)  
		{
			Score score = GameObject.FindObjectOfType<Score> ();
			score.SetScore (500);
			Destroy (gameObject);
		}
	}
}
