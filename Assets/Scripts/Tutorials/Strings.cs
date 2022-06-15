using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello my name is Bjarne.");
        print("Hello".Length + "Bjarne".Length); // 5 + 6 = 11
        print("Elephant".Substring(3,4)); // "phan"
    }

    // Update is called once per frame
    void Update()
    {

    }
}
