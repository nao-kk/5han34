using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
    public TMP_Text score2;
    public AudioClip sound2;
    private AudioSource audioSource;
    public int score4 = 0;
    public GameObject pacPrefab;
    private int RandomNumber = 0;//追加　ランダムに出てきた数値を保存するよう
    private int itemswitch = 0;//今所持しているアイテムは何かの判定用

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RandomGet();//RandomGetを呼び出す
        itemswith();//itemswithを呼び出す
    }

    private void OnTriggerEnter(Collider collider)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (collider.gameObject.tag == "pac")
        {
            Destroy(collider.gameObject);//ゴールに入ったパックを削除
            audioSource = GetComponent<AudioSource>();//効果音を取得
            audioSource.PlayOneShot(sound2);//ゴールに入ったら効果音を再生
            Debug.Log("2Pの得点");
            score4++;
            score2.text = score4.ToString();//画面上にスコアを表示
            RandomItem();//追加
        }
    }

    private void RandomItem()
    {
        int num = Random.Range(1, 4);   // 1〜3までの整数からランダムで取得する
        RandomNumber = num;//RandomNumberという変数に先ほどのランダムに出た数値を保存
    }

    //追加
    private void RandomGet()
    {

        if (RandomNumber == 1)
        {
            Debug.Log("プレイヤー１がアイテム1を手に入れた");
            itemswitch = 1;// アイテム１を取得
            RandomNumber = 0;//数値を0に戻す
        }
        else if (RandomNumber == 2)
        {
            Debug.Log("プレイヤー１がアイテム2を手に入れた");
            itemswitch = 2;// アイテム2を取得
            RandomNumber = 0;//数値を0に戻す
        }
        else if (RandomNumber == 3)
        {
            Debug.Log("プレイヤー１がアイテム3を手に入れた");
            itemswitch = 3;// アイテム3を取得
            RandomNumber = 0;//数値を0に戻す
        }
    }

    private void itemswith()
    {
        if (itemswitch == 1)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Debug.Log("プレイヤー1がアイテム1を使用した");
                itemswitch = 0;//数値を0に戻す
            }
        }
        else if (itemswitch == 2)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Debug.Log("プレイヤー1がアイテム2を使用した");
                itemswitch = 0;//数値を0に戻す
            }
        }
        else if (itemswitch == 3)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Debug.Log("プレイヤー1がアイテム3を使用した");
                itemswitch = 0;//数値を0に戻す
            }
        }
    }
}