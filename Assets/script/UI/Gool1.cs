using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
    public AudioClip sound2;
    private AudioSource audioSource;

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
        if (collider.gameObject.tag == "goal2")
        {
            Destroy(this.gameObject);

            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound2);
        }
    }
}
