using UnityEngine;
using System.Collections;

public class HealthPickUp : MonoBehaviour 
{

	void Start () 
	{
	
	}

	void Update () 
	{
		transform.Rotate (new Vector3 (50, 0, 0) * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			PlayerHealth playerHealth = other.GetComponent<PlayerHealth> ();
			if(playerHealth != null)
			{
				playerHealth.addHealth (20);
			}
			Destroy (gameObject);
		}
	}
}
