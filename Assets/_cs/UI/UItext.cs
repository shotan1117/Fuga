using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UItext : MonoBehaviour
{
    public Text text;
    public int num=0;
    float textTime = 0;
   
    // Update is called once per frame
    void Update()
    {
        switch (num)
        {
            case 0:
                text.text = "";
                break;
            case 1:
                text.text = "ƒlƒW‚ªŠÉ‚ñ‚Å‚¢‚é...";
                break;
            case 4:
                text.text = "“ÝŠí‚ª‚ ‚ê‚ÎŠ„‚ê‚»‚¤...H";
                break;
            case 6:
                text.text = "“B‚ªŽK‚Ñ‚Ä‚¢‚é...“B”²‚ª‚ ‚ê‚Î”²‚¯‚»‚¤...H";
                break;
            case 9:
                text.text = "Œ®‚ªŠ|‚©‚Á‚Ä‚¢‚é...";
                break;
            case 12:
                text.text = "‰½‚©‚ªŒŒ‚Å‰B‚ê‚Ä‚é...•|‚¢‚¯‚Ç•z‚ª‚ ‚ê‚Î‚Ó‚«Žæ‚ê‚»‚¤‚©‚È...H";
                break;
            case 100:
                text.text = "”à‚Ì—§‚Ä•t‚¯‚ªˆ«‚­‚ÄŠJ‚¯‚ç‚ê‚È‚¢‚È‚Ÿ";
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
