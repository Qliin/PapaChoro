using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	private int currScore;
	private int winScore = 15;
	private Text scoreText;
	public GameObject winTxt;
	public GameObject gameOverTxt;
	public GameObject restartBtn;

	// Use this for initialization
	void Start () {
		currScore = 0;
		scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AddToScore(){
		++currScore;
		scoreText.text = currScore.ToString ();
		if (currScore == winScore) {
			ShowGameOver (winTxt);
//			winTxt.SetActive (true);
//			Time.timeScale = 0;
		}
	}

	void SubFromScore(){
		--currScore;
		scoreText.text = currScore.ToString ();
		if (currScore < 0) {
			ShowGameOver (gameOverTxt);
//			gameOverTxt.SetActive (true);
//			Time.timeScale = 0;
		}
	}

	void ShowGameOver(GameObject textToShow) {
		textToShow.SetActive (true);
		restartBtn.SetActive (true);
		Time.timeScale = 0;
	}

	public void RestartScene() {
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
