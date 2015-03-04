using UnityEngine;
using System.Collections;

public class MovRoca : MonoBehaviour {

	// Use this for initialization
	void Start () {


		rigidbody.AddForce(Random.Range(-20000,-10000),0,0);
		rigidbody.AddTorque(Random.Range(-40,40),Random.Range(-40,40),Random.Range(-40,40));
	
	}
	
	// Update is called once per frame
	void Update () {

		/*if(rigidbody.transform.position.x < -1500){
			Des

*/
	
	}
}
