using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI���g���Ƃ��ɕK�v

public class Timer_U: MonoBehaviour
{
    public  Goal2 Goal2;
    public  Goal1 Goal1;
    //�J�E���g�_�E��
    public float countdown = 5.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;

    private void Start()
    {
        Goal2 = GetComponent<Goal2>();
        Goal1 = GetComponent<Goal1>();
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1") + "�b";

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            timeText.text = "���ԂɂȂ�܂����I";
            if(Goal2.score3 < Goal1.score4) 
            {
             Debug.Log("1P�̏����ł��I");
            }
            else if(Goal2.score3 > Goal1.score4) 
            {
                Debug.Log("2P�̏����ł��I");
            }
            else 
            {
                Debug.Log("���������ł��I");
            }
        }
    }
}