using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygenelator : MonoBehaviour
{
    
    private void FixedUpdate()
    {
        // �����œ����悤�ɂ���
        this.transform.Translate(-0.045f, 0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            Application.LoadLevel("GameOverScene");
        }
    }
   
}
