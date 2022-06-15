using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    string[] playerNames = new string[]
    {
        "Bob", "Liam", "Noa", "Sam", "Leo"
    };

    int[] randomNumbers = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        print(playerNames[0]); // "Bob"
        print(playerNames[1]); // "Liam"

        playerNames[0] = "Rob";

        print(playerNames.Length); // 5

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = Random.Range(0, 100);
            print(randomNumbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
