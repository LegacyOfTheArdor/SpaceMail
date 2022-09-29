using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	
	/*public Transform playercamera;
	public float turnSpaceship = 0.1f;
	float turnvelocity;*/
	
	public float momentum = 30f;
	private float activeMomentum;

	public float TurnSpeed = 90f;
	private Vector2 SteerInput, screenCenter, mouseDistance;

	private void Start()
	{
		screenCenter.x = Screen.width * 0.5f;
		screenCenter.y = Screen.height * 0.5f;
	}
	// Update is called once per frame
	void Update()
    {
		steer();
		Accelerate();

    }

	public int activespeed()
	{
		if (Input.GetKey("w"))
		{
			return 1;
		}
		return 0;
	}

	private void steer()
	{
		SteerInput.x = Input.mousePosition.x;
		SteerInput.y = Input.mousePosition.y;

		mouseDistance.x = (SteerInput.x - screenCenter.x) / screenCenter.y;
		mouseDistance.y = (SteerInput.y - screenCenter.y) / screenCenter.y;

		mouseDistance = Vector2.ClampMagnitude(mouseDistance, 1f);

		transform.Rotate(-mouseDistance.y * TurnSpeed * Time.deltaTime, mouseDistance.x * TurnSpeed * Time.deltaTime, 0f, Space.Self);
	}

	private void Accelerate()
	{
		activeMomentum = activespeed() * momentum;

		transform.position += transform.forward * activeMomentum * Time.deltaTime;
	}

	private void centerMouse()
	{

	}
}
