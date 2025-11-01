using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalletHitSE : MonoBehaviour
{
    public AudioClip hitSE; // © Œø‰Ê‰¹‚ğ‚±‚±‚Éİ’è
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // ©“®‚ÅAudioSource‚ğ’Ç‰Á
    }

    void OnCollisionEnter(Collision collision)
    {
        // ‚Ô‚Â‚©‚Á‚½‘Šè‚ªuPuckv‚¾‚Á‚½‚ç
        if (collision.gameObject.CompareTag("Puck"))
        {
            audioSource.PlayOneShot(hitSE);
        }
    }
}

