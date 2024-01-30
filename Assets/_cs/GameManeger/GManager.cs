using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    public static GManager Instances;

    private int progressFlag = 0;
    public int ProgressFlag
    {
        get { return progressFlag; }
    }

    public Text text;

    // Update is called once per frame
    
    // Start is called before the first frame update
    void Awake()
    {
        if (Instances == null)
        {
            Instances = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        HintMSG(0);
    }
 
    public void HintMSG(int hintNo)
    {
        progressFlag = hintNo; 
        switch (progressFlag)
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
