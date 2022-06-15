using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndColdGame : MonoBehaviour
{
    int numberToGuess;
    [Range(0, 100)]
    public int numberGuessed = 0;
    int numberOfAttempts;

    // Start is called before the first frame update
    void Start()
    {
        numberToGuess = Random.Range(0, 101);
        if (numberToGuess > 100) { numberToGuess = 100; }
        numberOfAttempts = 0;
        print("welcome to the Hot & Cold number guessing game.");
        print("A random number between 0 and 100 has been chosen. Your goal is to find this number in the least attempts possible.");
        print("Enter in your guess and then press the space button to submit it. Good luck and have fun!");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            numberOfAttempts += 1;

            if (numberGuessed == numberToGuess)
            {
                print("YOU GUESSED CORRECT: " + numberToGuess.ToString() + ".\nIt took you " + numberOfAttempts.ToString() + " attempts to guess the number.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 10 )
            {
                print("Boiling.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 20)
            {
                print("Very hot.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 30)
            {
                print("Hot.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 40)
            {
                print("Warm.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 50)
            {
                print("Lukewarm.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 60)
            {
                print("Cold.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 70)
            {
                print("Quite cold.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 80)
            {
                print("Very cold.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 90)
            {
                print("Frigid.");
            }
            else if (Mathf.Abs(numberToGuess - numberGuessed) <= 100)
            {
                print("Freezing.");
            }
            else
            {
                print("DEBUG: This value should not happen :/");
            }
        }
    }
}
