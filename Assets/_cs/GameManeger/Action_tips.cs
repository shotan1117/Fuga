using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action_tips : MonoBehaviour
{
    public Text text;
    public int num = 0;
    float textTime = 0;

    // Update is called once per frame
    void Update()
    {

    }
    
    public void HintMSG(int hintNo)
    {
        switch (num)
        {
            case 0:
                text.text = "�ԍ��������ē���";
                break;
            case 1:
                text.text = "��K��T�����Ă݂悤";
                break;
            case 2:
                text.text = "���̊K���T�����Ă݂悤";
                break;
            case 3:
                text.text = "�����g����ꏊ��T���Ă݂悤";
                break;
            case 4:
                text.text = "���̊K��T�����Ă݂悤";
                break;
            case 5:
                text.text = "��̊K���畨�����E�E�E�T�����Ă݂悤";
                break;

            case 6:
                text.text = "���̔ԍ����������T���Ă݂悤";
                break;
        }
    }

}
