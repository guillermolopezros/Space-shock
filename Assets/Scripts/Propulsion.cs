﻿using UnityEngine;
using System.Collections;

public class Propulsion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey("c")){
			Vector3 pos = transform.position;
			pos.y = pos.y +10;
			transform.position = pos;

		}
	}
}