using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tear : MonoBehaviour {

	private GameObject score;
	private bool hit = false;
	// Use this for initialization
	void Start () {
		score = GameObject.FindGameObjectWithTag ("Score");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		if (!hit) {
			hit = true;
			if (col.gameObject.tag == "Boca") {
				score.SendMessage ("AddToScore");
			} else {
				score.SendMessage ("SubFromScore");
			}
		}
	}
}
