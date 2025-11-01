using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalletHitSE : MonoBehaviour
{
    public AudioClip hitSE; // �� ���ʉ��������ɐݒ�
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // ������AudioSource��ǉ�
    }

    void OnCollisionEnter(Collision collision)
    {
        // �Ԃ��������肪�uPuck�v��������
        if (collision.gameObject.CompareTag("Puck"))
        {
            audioSource.PlayOneShot(hitSE);
        }
    }
}

