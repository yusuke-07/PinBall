using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
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

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // Use this for initialization
    void Start()
    {
        //シーン中のScoreオブジェクトを取得
        this.scoreText = GameObject.Find("Score");

        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    // 衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        // 衝突対象に応じて得点を加算
        if (other.gameObject.tag == "SmallStarTag")
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