using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score1 : MonoBehaviour
{
    public TMP_Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("pac"))
        {
            Debug.Log("‚PP‚Ì“¾“_");
        }
    }
}
