using UnityEngine;
using System.Collections;

public class MovRoca : MonoBehaviour {

	// Use this for initialization
	void Start () {


		rigidbody.AddForce(Random.Range(-20000,-10000),0,0);
		rigidbody.AddTorque(Random.Range(-4000,-2000),Random.Range(4000,2000),Random.Range(20000,40000));

	

	}
	
	// Update is called once per frame
	void Update () {

		if(rigidbody.transform.position.x < -1500 || rigidbody.transform.position.x > 2000 || rigidbody.transform.position.y < -1000 || rigidbody.transform.position.y > 2000){
			Destroy(gameObject);

		}

	}
}
