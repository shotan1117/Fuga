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
    string[] endOne = { "あ...あれ？ここは...寝室？",
                        "あれは、夢だったの？", 
        "夢で良かった。あんな所にいるのは嫌だからね。" };
    string[] endTwo = { "あ...あれ？ここは...寝室？",
                        "あれは、夢だったの？",
        "夢で良かった。あんな所にいるのは嫌だからね。" ,
                        "あれ？おかしいな...。",
                        "この手にあるのは、家族写真？",
                        "懐かしいな。あれから、もう半年ね。",
                        "また会いたいな...。"
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
