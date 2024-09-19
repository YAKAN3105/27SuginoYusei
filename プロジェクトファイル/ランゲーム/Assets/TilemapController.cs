using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapControllerr : MonoBehaviour
{
    private float time = 0.0f; // Œo‰ßŽžŠÔ
    private float x = -0.045f;

    private float startPos;
    private float endPos;
    private float distance;

    private void Start()
    {
        time = GameObject.Find("TilemapGenerator").GetComponent<TilemapGenerator>().time;
        startPos = this.transform.position.x;
    }
    private void FixedUpdate()
    {

        // Ž©“®‚Å“®‚­‚æ‚¤‚É‚·‚é
        this.transform.Translate(x, 0, 0);
        time += Time.deltaTime;
        if(time > 10.0f)
        {
            x *= 1.2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        endPos = this.transform.position.x;
        distance = endPos - startPos;

        if (distance <= -20.0f)
        {
            Destroy(gameObject);
        }
    }
}
