using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	
	public static int cuboTele = 0;
	public static int cuboComb = 0;
	public static bool jugando = true;
	Animator anim;
	public GameObject canvas;

	public int maxGranadas = 5;		//numero maximo de granadas
	public int cubosGranadas = 0;	//Cubos en la escena - Crearemos cubos cuando < maxGranadas
	public int numGranadas = 0;		//numero de granadas disponibles

	public static int cuboTime = 0;
	public static int cuboSupernova = 0;

	public float timeRoca = 0.5f; // 0.05 va bien
	public float puntuacion = 0;
	public float puntuacionFinal;

	public int fuerzaPropulsor = 10;
	public float fuelLevel = 100f;
	public float consumoFuel = 1f;
	

		
	public static GameControl gamecontrol;
		
		void Start(){
			anim = canvas.GetComponent<Animator> ();
		}

		void Update(){
			if (GameControl.jugando){
				anim.SetBool("canvas_in", false);
			} else {
				anim.SetBool("canvas_in", true);
		}
		}

		void Awake(){
			if (gamecontrol == null) {
				gamecontrol = this;
				DontDestroyOnLoad (gameObject);
			} else if (gamecontrol != this) {
				Destroy (this);
			}
		}
		
		public void Restart(){
			GameControl.jugando = true;
			Application.LoadLevel (Application.loadedLevel);
		}

	public void level_2(){
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


	
	

