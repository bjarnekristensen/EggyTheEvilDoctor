using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int number1 = 0;
    public int number2 = 0;

    public string action = "add";

    // Start is called before the first frame update
    void Start()
    {
        if (action == "add")
        {
            print(number1 + number2);
        }
        else if (action == "subtract")
        {
            print(number1 - number2);
        }
        else if (action == "multiply")
        {
            print(number1 * number2);
        }
        else if (action == "divide")
        {
            if (number2 != 0)
            {
                print(number1 / number2);
            }
            else
            {
                print("You cannot divide by 0.");
            }
        }
        else
        {
            print("The action does not exist.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
