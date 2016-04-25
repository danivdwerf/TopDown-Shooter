using UnityEngine;
using System.Collections;

public class DeleteDoor : MonoBehaviour 
{

	void Start () 
	{
		gameObject.active = true;
	}

	public void Deactivate()
	{
		gameObject.active = false;
	}
}
