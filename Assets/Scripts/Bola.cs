using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Membuat variable untuk mereferensikan sfx bounce bola
    [SerializeField]
    AudioSource sfxBola;
    // Membuat variable untuk mereferensikan vfx bola
    [SerializeField]
    ParticleSystem vfxBola;

    private void OnCollisionEnter(Collision other)
    {
        // Memutar audio sfx bounce
        sfxBola.Play();
        // Memutar vfx bola
        vfxBola.Play();
    }
}
