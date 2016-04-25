using UnityEngine;
using System.Collections;

public class XboxMovement : MonoBehaviour 
{
	private Vector3 movement;
	private Rigidbody rigidBody; 
 	public float movementSpeed = 8;  

	void Awake()
	{
		rigidBody = GetComponent<Rigidbody>();
	} 

	void Update()  
	{
		movement.x = Input.GetAxis ("LeftJoystickX") * movementSpeed;
		movement.z = Input.GetAxis("LeftStickY") * movementSpeed;

		Vector3 velocity = movement.normalized * movementSpeed * Time.fixedDeltaTime;
		rigidBody.MovePosition(rigidBody.position + velocity);
	}
 }