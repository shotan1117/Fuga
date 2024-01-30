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
                text.text = "”Ô†‚ğŒ©‚Â‚¯‚Ä“ü—Í";
                break;
            case 1:
                text.text = "ˆêŠK‚ğ’Tõ‚µ‚Ä‚İ‚æ‚¤";
                break;
            case 2:
                text.text = "‘¼‚ÌŠK‚à’Tõ‚µ‚Ä‚İ‚æ‚¤";
                break;
            case 3:
                text.text = "Œ®‚ğg‚¦‚éêŠ‚ğ’T‚µ‚Ä‚İ‚æ‚¤";
                break;
            case 4:
                text.text = "‚±‚ÌŠK‚ğ’Tõ‚µ‚Ä‚İ‚æ‚¤";
                break;
            case 5:
                text.text = "ã‚ÌŠK‚©‚ç•¨‰¹‚ªEEE’Tõ‚µ‚Ä‚İ‚æ‚¤";
                break;

            case 6:
                text.text = "‘¼‚Ì”Ô†‚ª–³‚¢‚©’T‚µ‚Ä‚İ‚æ‚¤";
                break;
        }


    }
}
