using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberTicker : MonoBehaviour
{
    public GameObject[] digits = new GameObject[10];
    private int digit = 0;

    public int Digit
    {
        get { return digit; }
        set {
            if (value < 0) { value = 0; }
            else if (value > 9) { value = 9; }
            digits[digit].GetComponent<Image>().enabled = false;
            digits[value].GetComponent<Image>().enabled = true;
            digit = value;
        }
    }
}
