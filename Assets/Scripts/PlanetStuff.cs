using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetStuff : MonoBehaviour
{
	bool hasPackage;
	GameObject IceP;
	GameObject SandP;
	GameObject HotP;
	GameObject JungleP;
	GameObject RobotP;
	GameObject GasP;
	GameObject SpaceP;
	GameObject EarthP;
	GameObject RockyP;
	GameObject Target;

	public PlayerMovement playerMovement;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

	}

	void collectPackage()
	{
		if (hasPackage == false)
		{
			hasPackage = true;

		}
	}

	void EnterPlanet() 
	{
		bool inPlanet = false;

		if (playerMovement.momentum < 10)
		{

		}

	}

	void NewTargetPlanet()
	{
		GameObject[] newtarget;
		GameObject previoustarget;
		int index;

		newtarget = GameObject.FindGameObjectsWithTag("DeliverTarget");

	}
}
