using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
	public Text score;
	public int playerScore = 0;

	private void Start()
	{
		currentScore();
	}

	private void Update()
	{
		currentScore();
	}
	
	 public void currentScore()
	{
		score.text = "Score : " + playerScore.ToString();
	}

	public void calculateHighscorePlace()
	{
		
	}


}
