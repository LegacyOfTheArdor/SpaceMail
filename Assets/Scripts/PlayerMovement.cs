using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	
	/*public Transform playercamera;
	public float turnSpaceship = 0.1f;
	float turnvelocity;*/
	
	public float momentum = 100f;
	private float activeMomentum;

	public float TurnSpeed = 90f;
	private Vector2 SteerInput, screenCenter, mouseDistance;
	private float SteerY;
	private float SteerX;
	private float mouseSide;

	private void Start()
	{
		centerScreen();
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

		SteerX = mouseDistance.x * TurnSpeed * Time.deltaTime;
		SteerY = -mouseDistance.y * TurnSpeed * Time.deltaTime;

		transform.Rotate(SteerY,SteerX, 0f, Space.Self);
		

	}

	private void Accelerate()
	{
		activeMomentum = activespeed() * momentum;

		transform.position += transform.forward * activeMomentum * Time.deltaTime;
	}

	private void centerScreen()
	{
		screenCenter.x = Screen.width * 0.5f;
		screenCenter.y = Screen.height * 0.5f;
	}

	private void steerTurn()
	{
		SteerInput.x = Input.mousePosition.x;

		mouseSide = SteerInput.x - screenCenter.x;

		if(mouseSide < screenCenter.x)
		{
			transform.Rotate(0f, 0f, -0.00005f);
		}
		else if(mouseSide > screenCenter.x)
		{
			transform.Rotate(0f, 0f, 0.00005f);
		}
	}
}
