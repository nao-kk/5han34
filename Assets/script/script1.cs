using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    void Start()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("ボタンが押された");
        }
    }
}
