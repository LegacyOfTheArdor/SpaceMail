using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
	bool inHitbox;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "MapHitbox")
		{
			inHitbox = true;
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
			inHitbox = false;
			print("exit");
		}
	}
}
