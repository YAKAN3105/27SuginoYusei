using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEcon : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // ボタンが押されたときに音を鳴らす
      //  if(Input.GetButton)
    }
}
