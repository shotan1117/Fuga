using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UItext : MonoBehaviour
{
    public Text text;
    public int num=0;
    float textTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (num)
        {
            case 0:
                text.text = "";
                break;
            case 1:
            text.text = "�l�W���ɂ�ł���...";
            break;
        case 4:
            text.text = "�݊킪����Ί��ꂻ��...�H";
            break;
            case 6:
                text.text = "�B���K�тĂ���...�B��������Δ�������...�H";
                break;
            case 12:
                text.text = "���������ŉB��Ă�...�|�����Ǖz������΂ӂ���ꂻ������...�H";
                break;


        }

        if(num!=0)
        {
            textTime += Time.deltaTime;
        }
        if(textTime > 5) 
        {
            num = 0;
            textTime = 0;
        
        }

        }
    }
