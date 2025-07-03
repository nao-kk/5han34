using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWallSystem : MonoBehaviour
{
    [SerializeField, Header("�Ăяo������")] private GameObject SpawnObject;
    [SerializeField, Header("�Ăяo���ꏊ�P")] private GameObject SpawnPoint1;
    [SerializeField, Header("�Ăяo���ꏊ�Q")] private GameObject SpawnPoint2;


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
