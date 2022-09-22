using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController playercontroller;
	public Transform ThirdPersonCamera;

	public float momentum = 30f;

    // Update is called once per frame
    void Update()
    {
		float forward = Input.GetAxisRaw("Vertical");
		Vector3 direction = new Vector3(0f, 0f, forward).normalized;

		if (Input.GetKey(KeyCode.W))
		{
			if (direction.magnitude >= 0.1f)
			{
				playercontroller.Move(direction * momentum * Time.deltaTime);
			}
		}
    }
}
