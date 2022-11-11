using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
	bool inMap;
	public GameObject closestTarget;
	public GameObject playership;
	

	private PlanetStuff planetStuff;
	Player player;

	public float smoothturn = 0.1f;
	float turnsmoothY;
	float turnsmoothX;

	private void Start()
	{
		planetStuff = playership.GetComponent<PlanetStuff>();
		player = GetComponent<Player>();
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "MapHitbox")
		{
			inMap = true;
			print("enter");
		}
		if (other.gameObject.tag == "DeliverTarget")
		{
			closestTarget = other.gameObject;
			planetStuff.EnterPlanet();
			print("enterTarget");


		}
		if (other.gameObject.tag == "Atmosphere")
		{
			float angleY = Mathf.SmoothDampAngle(transform.eulerAngles.y, 180, ref turnsmoothY, smoothturn);
			float angleX = Mathf.SmoothDampAngle(transform.eulerAngles.x, 180, ref turnsmoothX, smoothturn);
			playership.transform.Rotate(angleX, 0, angleY);
			print("to close");
		}
		if (other.gameObject.tag == "sun")
		{
			player.sun();
		}
		

	}

	private void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "sunheat")
		{
			
			player.sunheat();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "MapHitbox")
		{
			inMap = false;
			print("exit");
		}
	}
}
