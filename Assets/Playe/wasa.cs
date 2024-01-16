using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasa : MonoBehaviour
{
    // Start is called before the first frame update

    KeyUIText KeyUIText = null;

    int KeyChackNo;
    public void KeyChack(int KeyNo, KeyUIText UIText)
    {
        KeyChackNo = KeyNo;
        KeyUIText = UIText;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(code))
                {
                    if (KeyChack(code))
                    {
                        InputManeger.Instance.Key[KeyChackNo] = code;
                        KeyUIText.ChangeUIText(code.ToString());
                        this.gameObject.SetActive(false);
                    }
                    break;
                }
            }
        }
    }
  bool KeyChack( KeyCode Key)
    {
        for(int i = 0; i < InputManeger.Instance.Key.Count; i++) 
        {
            if(InputManeger.Instance.Key[i]== Key)
            {
                return false;
            }
        }
        return true;
    }
}
