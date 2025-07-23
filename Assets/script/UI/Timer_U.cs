using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer_U: MonoBehaviour
{
    [SerializeField] private  Goal2 Goal2;
    [SerializeField] private  Goal1 Goal1;
    [SerializeField] private TMP_Text CountText;
    [SerializeField] GameObject Win1P; 
    [SerializeField] GameObject Win2P;
    [SerializeField] GameObject Draw;
    public float countdownMinutes = 3;
    private float countdownSeconds;
    public TMP_Text time;
    public TMP_Text contdowntime;
    float countdown = 4f;
    int count;

    private void Start()
    {
        time = GetComponent<TMP_Text>();
        countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {

        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountText.text = count.ToString();
        }
        else
        {
            contdowntime.text = "Game Start!";
            CountText.text = "";
            Counttime();
        }
    }

    void Counttime()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        time.text = span.ToString(@"mm\:ss");

        if (countdownSeconds <= 0)
        {
            // 0ïbÇ…Ç»Ç¡ÇΩÇ∆Ç´ÇÃèàóù
            time.text = "Game Set!";
            if (Goal2.score3 < Goal1.score4)
            {
                Debug.Log("2PÇÃèüÇøÇ≈Ç∑ÅI");
                Win2P.SetActive(true);
            }
            else if (Goal2.score3 > Goal1.score4)
            {
                Debug.Log("1PÇÃèüÇøÇ≈Ç∑ÅI");
                Win1P.SetActive(true);
            }
            else
            {
                Debug.Log("à¯Ç´ï™ÇØÇ≈Ç∑ÅI");
                Draw.SetActive(true);
            }
            Invoke("title", 3.5f);
        }
    }

    void title()
    {
        SceneManager.LoadScene("title");
    }
}