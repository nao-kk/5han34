using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを使うときに必要

public class Timer_U: MonoBehaviour
{
    public  Goal2 Goal2;
    public  Goal1 Goal1;
    //カウントダウン
    public float countdown = 5.0f;

    //時間を表示するText型の変数
    public Text timeText;

    private void Start()
    {
        Goal2 = GetComponent<Goal2>();
        Goal1 = GetComponent<Goal1>();
    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") + "秒";

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            timeText.text = "時間になりました！";
            if(Goal2.score3 < Goal1.score4) 
            {
             Debug.Log("1Pの勝ちです！");
            }
            else if(Goal2.score3 > Goal1.score4) 
            {
                Debug.Log("2Pの勝ちです！");
            }
            else 
            {
                Debug.Log("引き分けです！");
            }
        }
    }
}