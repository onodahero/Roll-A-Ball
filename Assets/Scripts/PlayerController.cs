using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private void FixedUpdate ()
	{
		float x = Input.GetAxis ("Horizontal");	// Horizontal は水平方向
		float z = Input.GetAxis ("Vertical");	// Vertical は垂直方向	


		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		rigidbody.AddForce (x, 0, z);

		if(Input.GetKeyDown(KeyCode.Space) && rigidbody.velocity.y == 0.00f){
			rigidbody.AddForce (0, 200, 0);
		}

		if (Input.GetKey(KeyCode.X)) {
			rigidbody.velocity = Vector3.zero;
		}
	}
}