using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreAddition : MonoBehaviour
{
    //スコアを表示するテキスト
    private GameObject scoreText;
    
    // デフォルトの点数
    private int score = 0;

    // SmallStarの得点
    private int smallstar = 10;

    // LargeStarの得点
    private int largestar = 20;

    // SmallCloudの得点
    private int smallcloud = 30;

    // LargeCloudの得点
    private int largecloud = 50;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreオブジェクトを取得
        this.scoreText = GameObject.Find("Score");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        // 衝突対象に応じて得点を加算
        if (other.gameObject.tag == "SmallStarTag" )
        {
            this.score += this.smallstar;
        }

        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += this.largestar;
        }

        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += this.smallcloud;
        }

        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += this.largecloud;
        }

        // 得点を表示
        this.scoreText.GetComponent<Text>().text = this.score.ToString();

    }
}
