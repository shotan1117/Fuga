using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UItext : MonoBehaviour
{
    public Text text;
    public int num=0;
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

            case 1:
            text.text = "ネジが緩んでいる...";
            break;
        case 4:
            text.text = "鈍器があれば割れそう...？";
            break;
            case 6:
                text.text = "釘が錆びている...釘抜があれば抜けそう...？";
                break;
            case 12:
                text.text = "何かが血で隠れてる...怖いけど布があればふき取れそうかな...？";
                break;


        }


        }
    }
