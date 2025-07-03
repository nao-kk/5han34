using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
    [SerializeField, Header("è¡Ç¶ÇÈÇ‹Ç≈ÇÃéûä‘")] private float Destroytime = 0.0f;
    void Start()
    {
        Destroy(this.gameObject, Destroytime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
