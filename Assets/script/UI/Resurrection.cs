using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resurrection : MonoBehaviour
{
    public GameObject pacPrefab;
    private GameObject spawnedPac;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] pacs = GameObject.FindGameObjectsWithTag("pac");

        if (pacs.Length == 0)
        {
            spawnedPac = Instantiate(pacPrefab, transform.position, transform.rotation);
        }
    }
}
