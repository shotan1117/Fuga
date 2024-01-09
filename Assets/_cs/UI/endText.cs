using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endText : MonoBehaviour
{
    Text t;
    [SerializeField]
    public int end = 0;
    float textTime = 0;
    string[] endOne = { "��...����H������...�Q���H",
                        "����́A���������́H", 
        "���ŗǂ������B����ȏ��ɂ���̂͌�������ˁB" };
    string[] endTwo = { "��...����H������...�Q���H",
                        "����́A���������́H",
        "���ŗǂ������B����ȏ��ɂ���̂͌�������ˁB" ,
                        "����H����������...�B",
                        "���̎�ɂ���̂́A�Ƒ��ʐ^�H",
                        "���������ȁB���ꂩ��A�������N�ˁB",
                        "�܂��������...�B"
    };
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (end)
        {
            case 1:
                textTime += Time.deltaTime;
                int i = (int)(textTime / 4);
                if (i > 2) i = 2;
                t.text = endOne[i];

            break;
            

            case 2:
                textTime += Time.deltaTime;
                int ii = (int)(textTime / 4);
                if (ii > 6) ii = 6;
                t.text = endTwo[ii];
                break;
        }
        
    }
}
