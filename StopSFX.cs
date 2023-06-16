using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSFX : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter(Collider other)
    {
        playSound.Stop();
    }
}
