using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStartRandomizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play(0, 0, Random.Range(0f, 0.3f));
    }
}
