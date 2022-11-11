using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	public Image Playerhealthbar;
	public float Playerhealth = 100f;
	public float Maxhealth = 100f;

	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		healthchange();
		correctaHealth();
		isDead();
    }
	
	void healthchange()
	{
		Playerhealthbar.fillAmount = Playerhealth / 100f;
	}

	public void heal()
	{
		float damageTaken = Playerhealth - Maxhealth;
		float healingcurve = Maxhealth / 3 * 2;
		if(damageTaken >= healingcurve)
		{
			float health = damageTaken / 3 * 2;
			
			Playerhealth = Playerhealth + health;
		}
	}

	void correctaHealth()
	{
		if (Playerhealth > 100)
		{
			Playerhealth = 100;
		}
		if(Playerhealth < 0)
		{
			Playerhealth = 0;
		}
	}

	void isDead()
	{
		if(Playerhealth <= 0)
		{
			SceneManager.LoadScene("HighscoreScreen");
		}
	}

	public void sun()
	{
		Playerhealth = 0;
	}

	public void sunheat()
	{
		Playerhealth = Playerhealth - 1;
		
	}

}
