using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
    public TMP_Text score2;
    public AudioClip sound2;
    private AudioSource audioSource;
    public int score4 = 0;
    public GameObject pacPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (collider.gameObject.tag == "pac")
        {
            Destroy(collider.gameObject);
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound2);
            Debug.Log("2P‚Ì“¾“_");
            score4++;
            score2.text = score4.ToString();

        }
    }
}
