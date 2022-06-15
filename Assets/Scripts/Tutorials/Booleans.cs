using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booleans : MonoBehaviour
{
    public int age = 0;

    // Start is called before the first frame update
    void Start()
    {
        bool statement1 = 1 == 1;
        print("statement1: " + statement1);

        bool statement2 = 5 > 5;
        print("statement2: " + statement2);

        bool statement3 = 500 != 300;
        print("statement3: " + statement3);

        bool isAdult = age >= 18;
        print("isAdult: " + isAdult);

        bool complexStatement1 = 5 < 10 && 5 != 5; //true + false -> false because &&
        print("complexStatement1: " + complexStatement1);

        bool complexStatement2 = 5 < 10 || 5 != 5; //true + false -> true because ||
        print("complexStatement2: " + complexStatement2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
