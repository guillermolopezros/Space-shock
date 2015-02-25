using UnityEngine;
using System.Collections;


public static class GameControl {
	
	public static int cuboTele = 0;
	public static int cuboComb = 0;

	public static int maxGranadas = 5;		//numero maximo de granadas
	public static int cubosGranadas = 1;	//Cubos en la escena - Crearemos cubos cuando < maxGranadas
	public static int numGranadas = 0;		//numero de granadas disponibles

	public static int cuboTime = 0;
	public static int cuboSupernova = 0;
	public static GameControl gamecontrol;
	

	void Awake(){
		if (gamecontrol == null) {
			gamecontrol = this;
			DontDestroyOnLoad (gameObject);
		} else if (gamecontrol != this) {
			Destroy (this);
		}
	}
	
	public void Level2(){
		Application.LoadLevel ("Terreno");
	}
}