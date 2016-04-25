using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	private int _PlayerHealth = 100;
	public Text healthText;  

	void Awake()
	{
		_PlayerHealth = 100;
	}

	void Update()
	{
		healthText.text = "Health: " + _PlayerHealth.ToString() + "/100";
	}

	public void addHealth(int health)
	{
		if (_PlayerHealth != 100) 
		{
			_PlayerHealth += health;
		}

		if (_PlayerHealth > 100) 
		{
			_PlayerHealth = 100;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Enemy1"))
		{
			_PlayerHealth -= 5;	
		}

		if(other.gameObject.CompareTag("Enemy2"))
		{
			_PlayerHealth -= 10;	
		}

		if(other.gameObject.CompareTag("Enemy3"))
		{
			_PlayerHealth -= 50;	
		}

		if (_PlayerHealth <= 0) 
		{
			Debug.Log ("Dead");
		}
	}
}
