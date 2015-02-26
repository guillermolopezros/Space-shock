using UnityEngine;
using System.Collections;

public class MovRoca : MonoBehaviour {

	// Use this for initialization
	void Start () {


		rigidbody.AddForce(Random.Range(-20000,-10000),0,0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
