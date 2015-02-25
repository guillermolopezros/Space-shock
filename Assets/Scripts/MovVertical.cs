using UnityEngine;
using System.Collections;

public class MovVertical : MonoBehaviour {
	
	public float jumpSpeed = 500f;
	public bool standing;
	
	private float initJump;
	void Start(){

	}
	
	// Update is called once per frame
	void Update () {
		var absVelY = Mathf.Abs(rigidbody.velocity.y);

		
		/*if( Input.GetKeyDown("space")){
			rigidbody.AddForce(new Vector3(0, jumpSpeed), 0);
		}*/

		if(Input.GetKey("space")){
			rigidbody.AddForce(new Vector3(0, jumpSpeed,0));
	}
}
	}