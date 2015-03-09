using UnityEngine;
using System.Collections;

public class ColisionAsteroides : MonoBehaviour {

	public GameObject particulas;



	
	void OnCollisionEnter (Collision col){
		if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Player")	{
			Destroy(gameObject);

			Instantiate(particulas, transform.position, Quaternion.identity);   
			Debug.Log("Asteroide destruido");

		}
	}








}
		
	