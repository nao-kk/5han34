using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_U: MonoBehaviour
{
    [SerializeField] private  Goal2 Goal2;
    [SerializeField] private  Goal1 Goal1;
    public float countdownMinutes = 3;
    private float countdownSeconds;
    private Text timeText;

    private void Start()
    {
        timeText = GetComponent<Text>();
        countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");

        if (countdownSeconds <= 0)
        {
            // 0�b�ɂȂ����Ƃ��̏���
            timeText.text = "Game Set!";
            if (Goal2.score3 < Goal1.score4)
            {
                Debug.Log("2P�̏����ł��I");
            }
            else if (Goal2.score3 > Goal1.score4)
            {
                Debug.Log("1P�̏����ł��I");
            }
            else
            {
                Debug.Log("���������ł��I");
            }
        }
    }
}