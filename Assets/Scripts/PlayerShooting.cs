using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour 
{
	public Projectile projectile;
	public Transform muzzle;
	public float bulletSpeed;
	public float fireRate;

	private float nextFireTime;

	void Start()
	{
		nextFireTime = 0;
	}

	void Update ()
	{
		if (Input.GetMouseButton (0) && Time.time >= nextFireTime) 
		{
			Shoot();
		}
	}

	private void Shoot()
	{
		Projectile newProjectile = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
		newProjectile.setSpeed (bulletSpeed);
		nextFireTime = Time.time + fireRate;
	}
}
