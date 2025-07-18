using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer_U: MonoBehaviour
{
    [SerializeField] private  Goal2 Goal2;
    [SerializeField] private  Goal1 Goal1;
    [SerializeField] GameObject Win1P; 
    [SerializeField] GameObject Win2P;
    [SerializeField] GameObject Draw;
    public float countdownMinutes = 3;
    private float countdownSeconds;
    public TMP_Text time;

    private void Start()
    {
        time = GetComponent<TMP_Text>();
        countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        time.text = span.ToString(@"mm\:ss");

        if (countdownSeconds <= 0)
        {
            // 0秒になったときの処理
            time.text = "Game Set!";
            if (Goal2.score3 < Goal1.score4)
            {
                Debug.Log("2Pの勝ちです！");
                Win2P.SetActive(true);
            }
            else if (Goal2.score3 > Goal1.score4)
            {
                Debug.Log("1Pの勝ちです！");
                Win1P.SetActive(true);
            }
            else
            {
                Debug.Log("引き分けです！");
                Draw.SetActive(true);
            }
        }
    }
}