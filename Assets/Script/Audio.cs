using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    AudioSource myAudio;
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.PlayDelayed(5f);
    }
}
