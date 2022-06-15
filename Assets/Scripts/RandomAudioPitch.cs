using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioPitch : MonoBehaviour
{
    AudioSource source;
    [Tooltip("A value of 0.2 will randomize pitch between 0.8 an 1.2.")]
    public float pitchVariance = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.pitch = Random.Range(1 - pitchVariance, 1 + pitchVariance);
        source.Play();
    }
}
