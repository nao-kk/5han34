using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWallSystem : MonoBehaviour
{
    [SerializeField, Header("ŒÄ‚Ño‚·‚à‚Ì")] private GameObject SpawnObject;
    [SerializeField, Header("ŒÄ‚Ño‚·êŠ‚P")] private GameObject SpawnPoint1;
    [SerializeField, Header("ŒÄ‚Ño‚·êŠ‚Q")] private GameObject SpawnPoint2;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(SpawnObject, SpawnPoint1.transform.position, Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(SpawnObject, SpawnPoint2.transform.position, Quaternion.identity);
        }
    }
}
