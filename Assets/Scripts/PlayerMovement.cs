using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;
	public Animator catAnimator;

	public float forwardForce = 8000f;	// Variable that determines the forward force
	public float sidewaysForce = 120f;  // Variable that determines the sideways force

	void FixedUpdate ()
	{
		if (rb.position.y > 0f)
		{
			// Add a forward force
			rb.AddForce(0, 0, forwardForce * Time.deltaTime);
			catAnimator.SetBool("RunLeft",false);
			catAnimator.SetBool("RunRight",false);

			if (Input.GetKey("d"))	// If the player is pressing the "d" key
			{
				// Add a force to the right
				rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
				catAnimator.SetBool("RunRight",true);
			}

			if (Input.GetKey("a"))  // If the player is pressing the "a" key
			{
				// Add a force to the left
				rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
				catAnimator.SetBool("RunLeft",true);
			}
		}


		if (rb.position.y < -1f)
		{
			FindObjectOfType<NewGameManager>().EndGame();
			
		}
	}
}
