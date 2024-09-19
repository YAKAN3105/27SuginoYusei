using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapGenerator : MonoBehaviour
{
    
    public GameObject Grid;
    public GameObject Tilemap1;
    private float startPos;
    //private float endPos;
    //private float distance;
    public float time;
    Vector3 scale;

    GameObject Temp;

    private void Start()
    {
        startPos = this.transform.position.x;
    }
    private void FixedUpdate()
    {
        // ステージを生成する
        time += Time.deltaTime;

        if (time > 4)
        {
            Generate();
            // 時間の再計測
            time = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {

        // endPos = this.transform.position.x;
        // distance = endPos - startPos;
    }
    private void Generate()
    {
        scale.x = Random.Range(0.2f, 0.5f);
        scale.y = Random.Range(3, 5);
        scale.z = 1.0f;
        scale /= 10.0f;
        Temp = Instantiate(Tilemap1, new Vector3(3, Random.Range(-2, -5), 0), Quaternion.identity);
        Temp.transform.SetParent(Grid.transform, false);
        Temp.transform.localScale = scale;
    }
}
