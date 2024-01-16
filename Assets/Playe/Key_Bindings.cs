using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Bindings : MonoBehaviour
{
    [SerializeField]
    private int KeyNo;

    [SerializeField] KeyUIText KeyUIText;
    public wasa wasa;

    // Start is called before the first frame update
    void Start()
    {
        KeyUIText.ChangeUIText(InputManeger.Instance.Key[KeyNo].ToString());
    }
   
    public void OnClick()
    {
       wasa.gameObject.SetActive(true);
        wasa.KeyChack(KeyNo,KeyUIText);
    }
}
