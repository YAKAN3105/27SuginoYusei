using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    // プレイヤーのY座標をチェックするための閾値
    private float gameOverX = -10f;
    private float gameOverY = -20f;
    private Rigidbody2D rbody;
    private int isGround;
     void Start()
    {
        Application.targetFrameRate = 30;
        rbody = GetComponent<Rigidbody2D>();
        this.GetComponent<Animator>().Play("player_run");
    }
    private void Update()
    {
        // ジャンプ
            if (isGround < 2 && Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
            {
                rbody.velocity = new Vector2(0, 0);
                rbody.AddForce(new Vector2(0, 7f), ForceMode2D.Impulse);
                isGround ++;
            }
        // プレイヤーのX座標が閾値を下回った場合
        if (transform.position.x < gameOverX)
        {
            // GameverSceneに遷移
            SceneManager.LoadScene("GameOverScene");
        }
        

        // プレイヤーのY座標が閾値を下回った場合
        if (transform.position.y < gameOverY)
        {
            // GameOverSceneに遷移
            SceneManager.LoadScene("GameOverScene");
        }
    }
    private void FixedUpdate()
    {
        // 自動で動くようにする
        this.transform.Translate(0, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Goal")
        //{
        //    Debug.Log("ゴール");
        //    this.GetComponent<Animator>().Play("player_idle");
        //}

        // 追加
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("エネミーとぶつかった");
            rbody.velocity = new Vector2(0, 0);
            rbody.AddForce(new Vector2(-2f, 2f), ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "TileMap")
        {
            Debug.Log("着地");
            isGround = 0;
        }
       
    }
}
