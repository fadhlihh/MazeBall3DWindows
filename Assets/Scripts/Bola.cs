using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Membuat variable untuk mereferensikan sfx bounce bola
    [SerializeField]
    AudioSource sfxBola;

    private void OnCollisionEnter(Collision other)
    {
        // Memutar audio sfx bounce
        sfxBola.Play();
    }
}
