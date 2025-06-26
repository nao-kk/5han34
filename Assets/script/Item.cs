using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public List<GameObject> ItemPrefabs;
    public int numberOfItemsToSpawn = 1;
    // ランダムにアイテムを付与
    public void SpawnRandomItems()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {   
        
        Debug.Log("プレイヤーにアイテムが付与");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
