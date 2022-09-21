using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController playercontroller;

	public float momentum = 6f;

    // Update is called once per frame
    void Update()
    {
		/*float forward = Input.GetAxisRaw("forward");
		Vector3 direction = new Vector3(0f, 0f, forward).normalized;

			//if (direction.magnitude >= 0.1f)
			if (Input.GetKeyDown(KeyCode.W))
			{
				playercontroller.Move(direction * momentum * Time.deltaTime);
			}*/
    }
}
