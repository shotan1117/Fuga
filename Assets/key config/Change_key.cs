using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_key : MonoBehaviour
{
    [SerializeField]
    KeyUIText[] KeyUIText;

    int KeyChackNo;
    public void KeyChack(int KeyNo)
    {
        KeyChackNo = KeyNo;
    }

    void Update()
    {
        //押されたキー判定
        if (Input.anyKeyDown)
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(code))
                {
                    if(code != InputManeger.Instance.Key[6])
                    {
                        KeyChack(code);
                    }
                   
                }
            }
        }
    }
    void KeyChack(KeyCode Key)
    {
        for (int i = 0; i < InputManeger.Instance.Key.Count; i++)
        {
            if (InputManeger.Instance.Key[i] == Key)
            {
                //キーの入れ替え
                InputManeger.Instance.Key[i] = InputManeger.Instance.Key[KeyChackNo];
                KeyUIText[i].ChangeUIText(InputManeger.Instance.Key[i].ToString());
            }
        }
        //キー設定反映
        InputManeger.Instance.Key[KeyChackNo] = Key;
        KeyUIText[KeyChackNo].ChangeUIText(Key.ToString());
        this.gameObject.SetActive(false);
    }
}