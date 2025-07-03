using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oldscore1 : MonoBehaviour
{
    public Text scoreText;
    public Text win;
    public Text onemore;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (score >= 5)
        {
            if (Input.GetKey("space"))
            {
                score = 0;
                score2.score = 0;
                SceneManager.LoadScene("game1");
            }
        }
    }

    public void AddPoint(int point)
    {
        score = score + point;
        StartCoroutine("coroutine");
        if (score >= 5)
        {
            win.text = "1P win!!";
            onemore.text = "push space";
        }
    }

    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(2f);
        if (score <= 4)
        {
            SceneManager.LoadScene("game2");
        }
    }
}