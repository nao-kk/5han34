using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    private static BGMManager instance;

    void Awake()
    {
        // すでに別のBGMManagerが存在していたら自分を破棄
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // 自分をインスタンスとして保存
        instance = this;

        // シーンが切り替わっても破棄されないようにする
        DontDestroyOnLoad(gameObject);
    }
}
