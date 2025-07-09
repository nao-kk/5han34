using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal2 : MonoBehaviour
{
    public TMP_Text score1;
    public AudioClip sound2;
    private AudioSource audioSource;
    public int score3 = 0;
    public GameObject pacPrefab;
    private int RandomNumber = 0;//追加　ランダムに出てきた数値を保存するよう
    private int itemswitch = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //デバッグ用
        RandomGet();//RandomGetを呼び出す
        itemswith();//itemswithを呼び出す
    }
    private void OnTriggerEnter(Collider collider)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (collider.gameObject.tag == "pac")
        {
            Destroy(collider.gameObject);
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound2);
            Debug.Log("1Pの得点");
            score3++;
            score1.text = score3.ToString();
            RandomItem();//追加
        }
    }

    private void RandomItem()
    {
        int num = Random.Range(1, 4);   // 1～3までの整数からランダムで取得する
        RandomNumber = num;//RandomNumberという変数に先ほどのランダムに出た数値を保存
    }

    //追加
    private void RandomGet()
    {

        if (RandomNumber == 1)
        {
            Debug.Log("プレイヤー2がアイテム1を手に入れた");
            itemswitch = 1;// アイテム１を取得
            RandomNumber = 0;//数値を0に戻す
        }
        else if (RandomNumber == 2)
        {
            Debug.Log("プレイヤー2がアイテム2を手に入れた");
            itemswitch = 2;// アイテム１を取得
            RandomNumber = 0;//数値を0に戻す
        }
        else if (RandomNumber == 3)
        {
            Debug.Log("プレイヤーがアイテム3を手に入れた");
            itemswitch = 3;// アイテム１を取得
            RandomNumber = 0;//数値を0に戻す
        }
    }

    private void itemswith()
    {
        if (itemswitch == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Debug.Log("プレイヤー2がアイテム1を使用した");
                itemswitch = 0;//数値を0に戻す
            }
        }
        else if (itemswitch == 2)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Debug.Log("プレイヤー2がアイテム2を使用した");
                itemswitch = 0;//数値を0に戻す
            }
        }
        else if (itemswitch == 3)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Debug.Log("プレイヤー2がアイテム3を使用した");
                itemswitch = 0;//数値を0に戻す
            }
        }
    }
}