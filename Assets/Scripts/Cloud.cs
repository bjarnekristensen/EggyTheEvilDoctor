using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speed = 0.2f;
    float screenLimit = 10.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -screenLimit)
        {
            transform.position = new Vector3(screenLimit, transform.position.y);
        }
    }
}
