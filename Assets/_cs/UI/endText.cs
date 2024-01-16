using JetBrains.Annotations;
using NavKeypad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText : MonoBehaviour
{
    Text t;
    float textTime = 0;
    private int end;
    string[] endOne = { "��...����H������...�Q���H",
                        "����́A���������́H", 
        "���ŗǂ������B����ȕ|�����ɂ���̂͌�������ˁB" ,
                        "�[ END 1 �u���̖���..�v �["
    };
    string[] endTwo = { "��...����H������...�Q���H",
                        "����́A���������́H", 
        "���ŗǂ������B����ȏ��ɂ���̂͌�������ˁB" ,
                        "�E�E�E",
                        "����H����������...�B",
                        "�����...�Ƒ��ʐ^�H",
                        "���������ȁB���ꂩ��A�������N�ˁB",
                        "�܂��������...�B",
                        "�[ END 2 �u�m�X�^���W�A�v �["
    };

    private int i = 0;
    public int ii = 0;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
        end = PlayerPrefs.GetInt("flag");
    }

    // Update is called once per frame
    void Update()
    {

        switch (end)
        {
            case 1:
                t.color = Color.black;
                textTime += Time.deltaTime;
                i = (int)(textTime / 4);
                if (i > 3) i = 3;
                t.text = endOne[i];

            break;
            

            case 2:
                t.color = Color.black;
                textTime += Time.deltaTime;
                ii = (int)(textTime / 4);
                if (ii > 8) ii = 8;
                t.text = endTwo[ii];
                break;
        }
        
    }
}
