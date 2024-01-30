using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action_tips : MonoBehaviour
{
    public Text text;
    public int num = 0;

    // Update is called once per frame
    private void Start()
    {
        HintMSG(0);
    }

    public void HintMSG(int hintNo)
    {
        switch (num)
        {
            case 0:
                text.text = "番号を見つけて入力";
                break;
            case 1:
                text.text = "一階を探索してみよう";
                break;
            case 2:
                text.text = "他の階も探索してみよう";
                break;
            case 3:
                text.text = "鍵を使える場所を探してみよう";
                break;
            case 4:
                text.text = "この階を探索してみよう";
                break;
            case 5:
                text.text = "上の階から物音が・・・探索してみよう";
                break;

            case 6:
                text.text = "他の番号が無いか探してみよう";
                break;
        }
    }

}
