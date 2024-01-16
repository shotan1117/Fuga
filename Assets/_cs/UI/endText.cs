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
        "夢で良かった。あんな怖い所にいるのは嫌だからね。" ,
                        "ー END 1 「あの夢は..」 ー"
    };
    string[] endTwo = { "あ...あれ？ここは...寝室？",
                        "あれは、夢だったの？", 
        "夢で良かった。あんな所にいるのは嫌だからね。" ,
                        "・・・",
                        "あれ？おかしいな...。",
                        "これは...家族写真？",
                        "懐かしいな。あれから、もう半年ね。",
                        "また会いたいな...。",
                        "ー END 2 「ノスタルジア」 ー"
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
                t.color = Color.black;
                textTime += Time.deltaTime;
                int i = (int)(textTime / 4);
                if (i > 3) i = 3;
                t.text = endOne[i];

            break;
            

            case 2:
                t.color = Color.black;
                textTime += Time.deltaTime;
                int ii = (int)(textTime / 4);
                if (ii > 8) ii = 8;
                t.text = endTwo[ii];
                break;
        }
        
    }
}
