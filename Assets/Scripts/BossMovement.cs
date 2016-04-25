using UnityEngine;
using System.Collections;

public class BossMovement : MonoBehaviour 
{
	private bool _InArena;
	NavMeshAgent _navMeshAgent;
	GameObject _playerGameobject;

	void Awake()
	{
		_InArena = false;
		_navMeshAgent = GetComponent<NavMeshAgent> ();
		_playerGameobject = GameObject.FindGameObjectWithTag ("Player"); 
	}

	void Update()
	{
		if (_InArena == true) 
		{
			_navMeshAgent.SetDestination (_playerGameobject.transform.position);
		}
	}
	public void SetTrue()
	{
		_InArena = true;
	}
}
	