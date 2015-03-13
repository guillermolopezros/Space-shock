using UnityEngine;
using System.Collections;

public class Propulsion : MonoBehaviour {

	int fuerzaPropulsor;

	public Transform camara;
	// Use this for initialization
	void Start () {
	
		fuerzaPropulsor = GameControl.gamecontrol.fuerzaPropulsor;

		gameObject.GetComponent<CharacterController>().enabled = false;

	}



	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.C)){ // Ascenso
		rigidbody.AddForce(Vector3.up*fuerzaPropulsor,ForceMode.Impulse);
	}

	if(Input.GetKey(KeyCode.Space)){ //Descenso
		rigidbody.AddForce(Vector3.down*fuerzaPropulsor,ForceMode.Impulse);
	}

	if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
		rigidbody.AddForce(camara.forward*fuerzaPropulsor,ForceMode.Impulse); //left, right y back para el resto (forward)
		}

	if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
			rigidbody.AddForce(camara.forward*-fuerzaPropulsor,ForceMode.Impulse);
	}

	if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
			rigidbody.AddForce(camara.right*-fuerzaPropulsor,ForceMode.Impulse);
	}
	
	if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
			rigidbody.AddForce(camara.right*fuerzaPropulsor,ForceMode.Impulse);
	}

	}
}
