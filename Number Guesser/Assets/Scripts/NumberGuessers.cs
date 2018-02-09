using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessers : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		print ("Welcome to the number guesser.");
		print ("Pick a number in your head, don't tell me."); 

		int max = 500;
		int min = 1;

		print ("The highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");

		print ("Is the number higher or lower than 500?");
		print ("Press up for higher, down for lower and space for equals.");

	}
	
	// Update is called once per frame
	void Update ()
	{
			
		if (Input.GetKeyDown ("space"))
			print ("space key was pressed.");

		if (Input.GetKeyDown ("up"))
			print ("up was pressed");

		if (Input.GetKeyDown ("down"))
			print ("down was pressed");

	}
}
