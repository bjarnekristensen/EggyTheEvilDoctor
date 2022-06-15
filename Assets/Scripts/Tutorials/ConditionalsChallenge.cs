using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsChallenge : MonoBehaviour
{
    public float number1 = 0f;
    public float number2 = 0f;

    [Range(0, 100)]
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (number1 > number2)
        {
            print("Number 1 is bigger than Number 2.");
        }
        else if (number2 > number1)
        {
            print("Number 2 is bigger than Number 1.");
        }
        else
        {
            print("The numbers are the same.");
        }

        if (score >= 90)
        {
            print("You got an A");
        }
        else if (score >= 80)
        {
            print("You got a B");
        }
        else if (score >= 70)
        {
            print("You got a C");
        }
        else if (score >= 65)
        {
            print("You got a D");
        }
        else
        {
            print("You got an F");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
