using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{
	public Transform[] spawnLocations;
	public GameObject[] spawnPrefab;
	public GameObject[] spawnClone;

	private float _NormalEnemyTimer = 2.0f;
	private float _ToughEnemyTimer = 10.0f;

	void Update()
	{
		if(_NormalEnemyTimer > 0) 
		{
			_NormalEnemyTimer -= Time.deltaTime;
		}

		if(_ToughEnemyTimer > 0) 
		{
			_ToughEnemyTimer -= Time.deltaTime;
		}

		if (_NormalEnemyTimer <= 0) 
		{
			spawnClone [0] = Instantiate (spawnPrefab [0],spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
			_NormalEnemyTimer = 2.0f;
		}

		if (_ToughEnemyTimer <= 0) 
		{
			spawnClone [1] = Instantiate (spawnPrefab [1],spawnLocations[1].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
			_ToughEnemyTimer = 10.0f;
		}
	}
}
