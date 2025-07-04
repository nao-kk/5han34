using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal2 : MonoBehaviour
{
    public TMP_Text score1;
    public AudioClip sound2;
    private AudioSource audioSource;
    public int score3 = 0;
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
            Debug.Log("1P‚Ì“¾“_");
            score3++;
            score1.text = score3.ToString();
        }
    }
}