using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	
	public static int cuboTele = 0;
	public static int cuboComb = 0;

	public int maxGranadas = 5;		//numero maximo de granadas
	public int cubosGranadas = 0;	//Cubos en la escena - Crearemos cubos cuando < maxGranadas
	public int numGranadas = 0;		//numero de granadas disponibles

	public static int cuboTime = 0;
	public static int cuboSupernova = 0;

	public float timeRoca = 0.05f;



		
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

	public void Menu(){
		Application.LoadLevel ("Juego");
	}

	public void Credit(){
		Application.LoadLevel ("Credit");
	}
	public void Menu_inicial(){
		Application.LoadLevel ("Menu_inicial");
	}

	public void Salir(){
		Application.Quit ();
	}


}


	
	

