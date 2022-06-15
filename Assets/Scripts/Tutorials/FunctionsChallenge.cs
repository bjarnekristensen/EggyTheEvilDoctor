using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsChallenge : MonoBehaviour
{
    // Challenge 1
    bool IsEven(int number)
    {
        return (number % 2 == 0) ? true : false;
    }

    // Challenge 2
    int WhatIsBigger(int number1, int number2)
    {
        return (number1 > number2) ? number1 : number2;
    }

    // Challenge 3
    void Repeat(string text, int times)
    {
        for (int i = 1; i <= times; i++)
        {
            print(text);
        }
    }

    // Challenge 4
    int Factorial(int number)
    {
        if (number > 1)
        {
            number = number * Factorial(number - 1);
        }
        return number;
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Challenge 1: " + IsEven(2));
        print("Challenge 1: " + IsEven(5));
        print("Challenge 2: " + WhatIsBigger(-1, 2));
        print("Challenge 3: ");
        Repeat("hello", 5);
        print("Challenge 4: " + Factorial(5));
        print("Challenge 4: " + Factorial(3));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
