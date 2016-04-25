using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour 
{
	private int score;
	public Text scoreText;
	bool check;

	void Start () 
	{
		SetScore (0);
		check = true;
	}

	void Update()
	{
		if (score >= 10 && check==true) 
		{
			check=false;
			DeleteDoor deleteDoor = GameObject.FindObjectOfType<DeleteDoor> ();
			deleteDoor.Deactivate ();
		}
	}

	public void SetScore(int Points)
	{
		score += Points;
		scoreText.text = "Score: " + score.ToString();
	}
}
