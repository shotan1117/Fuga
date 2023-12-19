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
            text.text = "ƒlƒW‚ªŠÉ‚ñ‚Å‚¢‚é...";
            break;
        case 4:
            text.text = "“İŠí‚ª‚ ‚ê‚ÎŠ„‚ê‚»‚¤...H";
            break;
            case 6:
                text.text = "“B‚ªK‚Ñ‚Ä‚¢‚é...“B”²‚ª‚ ‚ê‚Î”²‚¯‚»‚¤...H";
                break;
            case 12:
                text.text = "‰½‚©‚ªŒŒ‚Å‰B‚ê‚Ä‚é...•|‚¢‚¯‚Ç•z‚ª‚ ‚ê‚Î‚Ó‚«æ‚ê‚»‚¤‚©‚È...H";
                break;


        }


        }
    }
