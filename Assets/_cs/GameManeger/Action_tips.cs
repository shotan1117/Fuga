using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action_tips : MonoBehaviour
{
    public Text text;
    public int num = 0;
    float textTime = 0;

    // Update is called once per frame
    void Update()
    {

    }
    
    public void HintMSG(int hintNo)
    {
        switch (num)
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
