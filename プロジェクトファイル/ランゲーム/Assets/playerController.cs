using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    // �v���C���[��Y���W���`�F�b�N���邽�߂�臒l
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
        // �W�����v
            if (isGround < 2 && Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
            {
                rbody.velocity = new Vector2(0, 0);
                rbody.AddForce(new Vector2(0, 7f), ForceMode2D.Impulse);
                isGround ++;
            }
        // �v���C���[��X���W��臒l����������ꍇ
        if (transform.position.x < gameOverX)
        {
            // GameverScene�ɑJ��
            SceneManager.LoadScene("GameOverScene");
        }
        

        // �v���C���[��Y���W��臒l����������ꍇ
        if (transform.position.y < gameOverY)
        {
            // GameOverScene�ɑJ��
            SceneManager.LoadScene("GameOverScene");
        }
    }
    private void FixedUpdate()
    {
        // �����œ����悤�ɂ���
        this.transform.Translate(0, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Goal")
        //{
        //    Debug.Log("�S�[��");
        //    this.GetComponent<Animator>().Play("player_idle");
        //}

        // �ǉ�
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("�G�l�~�[�ƂԂ�����");
            rbody.velocity = new Vector2(0, 0);
            rbody.AddForce(new Vector2(-2f, 2f), ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "TileMap")
        {
            Debug.Log("���n");
            isGround = 0;
        }
       
    }
}
