using UnityEngine;
using System.Collections;

public class Invisible : MonoBehaviour 
{
	void Update () 
	{
		gameObject.GetComponent<Renderer>().enabled = false;
	}
}
