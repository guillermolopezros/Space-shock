using UnityEngine;
using System.Collections;

public class Propulsion : MonoBehaviour {

	public int fuerzaPropulsor = 7;

	public Transform camara;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.Space)){ // Ascenso
		rigidbody.AddForce(Vector3.up*fuerzaPropulsor,ForceMode.Impulse);
	}

	if(Input.GetKey(KeyCode.LeftShift)){ //Descenso
		rigidbody.AddForce(Vector3.down*fuerzaPropulsor,ForceMode.Impulse);
	}

	if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
		rigidbody.AddForce(camara.forward*fuerzaPropulsor,ForceMode.Impulse); //left, right y back para el resto (forward)
		}

	if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S)){
			rigidbody.AddForce(new Vector3(-fuerzaPropulsor,0,0),ForceMode.Impulse);
	}

	if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A)){
			rigidbody.AddForce(new Vector3(0,0,fuerzaPropulsor),ForceMode.Impulse);
	}
	
	if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.D)){
			rigidbody.AddForce(new Vector3(0,0,-fuerzaPropulsor),ForceMode.Impulse);
	}

	}
}
