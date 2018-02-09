using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberGuesser : MonoBehaviour
{
	int max, min, guess, maxGuessesAllowed = 8;

	public Text guessText;

	// Use this for initialization
	void Start ()
	{
		StartGame ();

	}
		

	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}


	void StartGame ()
	{
		max = 1000; 
		min = 1; 
		NextGuess ();
	}

	void NextGuess ()
	{
		guess = Random.Range (min, max+1);
		guessText.text = guess.ToString();
		maxGuessesAllowed -= 1;
		if (maxGuessesAllowed <= 0)
			SceneManager.LoadScene ("Win");
	}

}

