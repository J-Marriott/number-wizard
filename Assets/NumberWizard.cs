using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuessesAvailable = 10;

	public Text text;

	void Start () {
		StartGame();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess();
	}

	public void GuessHigher (){
		min = guess;
		NextGuess();
	}

	public void GuessLower (){
		max = guess;
		NextGuess();
	}

	void NextGuess ()
	{
		guess = Random.Range(min, max+1);
		text.text = guess.ToString();
		maxGuessesAvailable -= 1;
		if (maxGuessesAvailable <= 0) {
			SceneManager.LoadScene("Win");
		}
	}
}
