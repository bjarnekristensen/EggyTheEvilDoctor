using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringsChallenge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(100 % 3); // 1
        print(("Orange" + "Pink")[7].ToString().ToUpper()); // "I"
        print("Black and white".Substring(6, 3).ToUpper()); // "AND"
        print("Programming"["Hello".Length % "Hi".Length + 7].ToString().ToUpper()); // "I"
    }

    // Update is called once per frame
    void Update()
    {

    }
}
