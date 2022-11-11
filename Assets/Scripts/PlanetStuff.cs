using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetStuff : MonoBehaviour
{
	bool hasPackage = false;
	
	
	/*3GameObject SandP;
	GameObject HotP;
	GameObject JungleP;
	GameObject RobotP;
	GameObject GasP;
	GameObject SpaceP;
	GameObject EarthP;
	GameObject RockyP;*/
	public GameObject Target;
	GameObject currentPlanet;
	public GameObject screenUi;
	public GameObject playership;

	public PlayerMovement playerMovement;
	public HighScore highScore;
	public HitboxScript hitboxScript;
	public Player player;

	public Toggle package;

	// Start is called before the first frame update
	void Start()
	{
		NewTargetPlanet();
		highScore = screenUi.GetComponent<HighScore>();
		hitboxScript = playership.GetComponent<HitboxScript>();
		player = playership.GetComponent<Player>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void Packagedelivery()
	{
		
		if (hasPackage == false)
		{
			hasPackage = true;
			package.isOn = true;
			currentPlanet.GetComponent<Outline>().enabled = false;
			player.heal();

		}
		else if(hasPackage == true)
		{
			hasPackage = false;
			highScore.playerScore = highScore.playerScore + 5;
			package.isOn = false;
			currentPlanet.GetComponent<Outline>().enabled = false;
			player.heal();
		}
	}

	public void EnterPlanet() 
	{
		
		currentPlanet = hitboxScript.closestTarget;
		if(currentPlanet == Target)
		{
			Packagedelivery();
			NewTargetPlanet();
		}

	}

	public void NewTargetPlanet()
	{

		GameObject tempPlanet = rPlanet();
		if(tempPlanet == currentPlanet)
		{
			tempPlanet = rPlanet();
			print("reroll");
		}
		Target = tempPlanet;
		Target.GetComponent<Outline>().enabled = true;
		print("got target");

	}

	GameObject rPlanet()
	{
		GameObject[] newtargetlist;
		GameObject nextTarget;
		int index;


		newtargetlist = GameObject.FindGameObjectsWithTag("DeliverTarget");
		index = Random.Range(0, newtargetlist.Length);
		nextTarget = newtargetlist[index];

		return nextTarget;
	}
}
