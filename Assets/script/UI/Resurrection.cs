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
        GameObject[] pacs = GameObject.FindGameObjectsWithTag("pac");//pac�^�O���擾

        if (pacs.Length == 0)//pac�̃^�O�������I�u�W�F�N�g���Ȃ��Ȃ�Ɠ���
        {
            //pac�𐶐�
            spawnedPac = Instantiate(pacPrefab, transform.position, transform.rotation);
        }
    }
}
