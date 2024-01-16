using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyUIText : MonoBehaviour
{
    public Text textUI;
   
    public void ChangeUIText(string text)
    {
        textUI.text = text;
    }
}
