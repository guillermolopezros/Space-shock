using UnityEngine;
using System.Collections;

public class Propulsion : MonoBehaviour {

	int fuerzaPropulsor;
	float fuelLevel;
	float consumoFuel;

	public Transform camara;
	// Use this for initialization
	void Start () {
	
		fuerzaPropulsor = GameControl.gamecontrol.fuerzaPropulsor;
		fuelLevel = GameControl.gamecontrol.fuelLevel;
		consumoFuel = GameControl.gamecontrol.consumoFuel;

		gameObject.GetComponent<CharacterController>().enabled = false;

	}



	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.C) && fuelLevel > 0){ // Ascenso
		rigidbody.AddForce(Vector3.up*fuerzaPropulsor,ForceMode.Impulse);
			fuelLevel -= consumoFuel * Time.deltaTime;
	}

		if(Input.GetKey(KeyCode.Space) && fuelLevel > 0){ //Descenso
		rigidbody.AddForce(Vector3.down*fuerzaPropulsor,ForceMode.Impulse);
			fuelLevel -= consumoFuel * Time.deltaTime;
	}

		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && fuelLevel > 0){
		rigidbody.AddForce(camara.forward*fuerzaPropulsor,ForceMode.Impulse); //left, right y back para el resto (forward)
			fuelLevel -= consumoFuel * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && fuelLevel > 0){
			rigidbody.AddForce(camara.forward*-fuerzaPropulsor,ForceMode.Impulse);
			fuelLevel -= consumoFuel * Time.deltaTime;
	}

		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) && fuelLevel > 0){
			rigidbody.AddForce(camara.right*-fuerzaPropulsor,ForceMode.Impulse);
			fuelLevel -= consumoFuel * Time.deltaTime;
	}
	
		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) && fuelLevel > 0){
			rigidbody.AddForce(camara.right*fuerzaPropulsor,ForceMode.Impulse);
			fuelLevel -= consumoFuel * Time.deltaTime;
	}

		Debug.Log ("COMBUSTIBLE: " + fuelLevel);
	}
}
