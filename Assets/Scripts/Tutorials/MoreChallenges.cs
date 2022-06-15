using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreChallenges : MonoBehaviour
{
    int SumArray(int[] intArray)
    {
        int result = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            result += intArray[i];
        }

        return result;
    }

    void PrintReverse(string[] stringArray)
    {
        for (int i = stringArray.Length - 1; i >= 0; i--)
        {
            print(stringArray[i]);
        }
    }

    int Max(int[] intArray)
    {
        int result = int.MinValue;

        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] > result)
            {
                result = intArray[i];
            }
        }

        return result;
    }

    bool IsUniform(string[] stringArray)
    {
        bool result = true;

        for (int i = 1; i < stringArray.Length; i++)
        {
            if (!(stringArray[i] == stringArray[0]))
            {
                result = false;
            }
        }

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        int[] intArr = new int[] { 5, 10, 2 };
        print("Challenge 1: " + SumArray(intArr));

        print("Challenge 2");
        string[] stringArr = new string[] { "hello", "my", "name", "is", "bjarne" };
        PrintReverse(stringArr);

        int[] intArr2 = new int[] { -7, 2, 6 };
        print("Challenge 3: " + Max(intArr2));

        string[] stringArr2 = new string[] { "hi" };
        print("Challenge 4: " + IsUniform(stringArr2));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
