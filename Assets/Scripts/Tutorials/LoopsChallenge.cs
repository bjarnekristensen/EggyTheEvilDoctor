using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsChallenge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Challenge 1: Print all numbers between -5 and 5.
        print("Challenge 1");
        for (int i = -5; i <= 5; i++)
        {
            print(i.ToString());
        }

        // Challenge 2: Print all even numbers between 10 and 50.
        print("Challenge 2");
        for (int i = 10; i <= 50; i += 2)
        {
            print(i.ToString());
        }

        // Challenge 3: Print numbers between 1 and 100 who are divisible by 5 and 3.
        print("Challenge 3");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                print(i.ToString() + " is divisible by 3 and 5");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
