using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
	bool inMap;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "MapHitbox")
		{
			inMap = true;
			print("enter");
		}
		

	}

	private void OnTriggerStay(Collider other)
	{
		
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
