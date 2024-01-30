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
                text.text = "暗証番号が必要なのかな？\n...探してみよう。";
                break;
            case 1:
                text.text = "とりあえず、一階を探索してみよう。";
                break;
            case 2:
                text.text = "他の階も探索してみよう。";
                break;
            case 3:
                text.text = "この鍵どこで使うんだろう...？";
                break;
            case 4:
                text.text = "この階も色々探索してみよう。";
                break;
            case 5:
                text.text = "他にも番号はあるのかな？";
                break;
            case 6:
                text.text = "番号がそろった気がする...\nさっきの所に入力しに行ってみよう。";
                break;
            case 100:
                text.text = "番号が違う..?なんでだろう？\n上の方...屋上？から物音が...";
                //"外から音がした気がする...\n外に行けるところに行ってみよう"
                break;
        }


    }
}
