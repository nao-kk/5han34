using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    private static BGMManager instance;

    void Awake()
    {
        // ���łɕʂ�BGMManager�����݂��Ă����玩����j��
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // �������C���X�^���X�Ƃ��ĕۑ�
        instance = this;

        // �V�[�����؂�ւ���Ă��j������Ȃ��悤�ɂ���
        DontDestroyOnLoad(gameObject);
    }
}
