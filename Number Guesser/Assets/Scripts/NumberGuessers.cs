using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessers : MonoBehaviour
{
	int max, min, guess;

	// Use this for initialization
	void Start ()
	{
		StartGame ();

	}
		
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetKeyDown ("up")) {
			print ("up was pressed");
			min = guess;
			NextGuess ();
			 
		} else if (Input.GetKeyDown ("down")) {
			print ("down was pressed");
			max = guess;
			NextGuess ();

		} else if (Input.GetKeyDown ("space")){
			print ("I won.");
			StartGame ();
		}
	}

	void StartGame ()
	{
		max = 1000; 
		min = 1; 
		guess = 500;
		print ("--------------------------New Game has started--------------------------");
		print ("Welcome to the number guesser.");
		print ("Pick a number in your head, don't tell me."); 

		print ("The highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");

		print ("Is the number higher or lower than " + guess + "?");
		print ("Press up for higher, down for lower and space for equals.");
		max += 1;
	}

	void NextGuess ()
	{
		guess = (max + min) / 2;
		print ("Is the the number higher or lower than, " + guess + "?");
		print ("Press up for higher, down for lower and space for equals.");
	}

}

