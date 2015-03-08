using UnityEngine;
using System.Collections;

public class ColisionAsteroides : MonoBehaviour {

	
	void OnCollisionEnter (Collision col){
		if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Player")
			{
				Destroy(gameObject);
			Debug.Log("Asteroide destruido");
			}
		}
	}