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

    private int gimmickcount = 0;
    public int Gimmickcount
    {
        get { return gimmickcount; }
        set { gimmickcount = value; }
    }

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
                text.text = "�Ïؔԍ����K�v�Ȃ̂��ȁH\n...�T���Ă݂悤�B";
                break;
            case 1:
                text.text = "�Ƃ肠�����A��K��T�����Ă݂悤�B";
                break;
            case 2:
                text.text = "���̊K���T�����Ă݂悤�B";
                break;
            case 3:
                text.text = "���̌��ǂ��Ŏg���񂾂낤...�H";
                break;
            case 4:
                text.text = "���̊K���F�X�T�����Ă݂悤�B";
                break;
            case 5:
                text.text = "���ɂ��ԍ��͂���̂��ȁH";
                break;
            case 6:
                text.text = "�ԍ�����������C������...\n�������̏��ɓ��͂��ɍs���Ă݂悤�B";
                break;
            case 100:
                text.text = "�ԍ����Ⴄ..?�Ȃ�ł��낤�H\n��̕�...����H���畨����...";
                //"�O���特�������C������...\n�O�ɍs����Ƃ���ɍs���Ă݂悤"
                break;
        }


    }
}
