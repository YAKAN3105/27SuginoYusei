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
        // Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // �{�^���������ꂽ�Ƃ��ɉ���炷
      //  if(Input.GetButton)
    }
}
