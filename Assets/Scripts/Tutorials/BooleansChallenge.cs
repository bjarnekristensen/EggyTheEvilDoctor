using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleansChallenge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Problem 1
        print((5 % 2 == 1 && 10 > 10) || (5 * 5 == 10 || "hey" == "hey")); // true because || and "hey" == "hey"

        // Problem 2
        print(("hello".Length >= 5 && 3.5f > 3.45f) && ("dragon".Length < 6 || "a" == "A")); // false because first statement is true and second is false

        // Problem 3
        string charName = "bob";
        string color = "blue";
        print((charName.Length > color.Length || charName[0] == color[0]) || (charName[2] == color[0] && 1 != 1)); // true because || and charName[0] == color[0]
    }

    // Update is called once per frame
    void Update()
    {

    }
}
