using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown ("joystick button 0")) {
            Debug.Log ("ボタンが押された");
        }
    }
}
