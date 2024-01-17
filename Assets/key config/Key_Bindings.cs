using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Bindings : MonoBehaviour
{
    [SerializeField]
    private int KeyNo;

    [SerializeField] KeyUIText KeyUIText;
    public Change_key Change_key;

    // Start is called before the first frame update
    void Start()
    {
        //�����e�L�X�g���f
        KeyUIText.ChangeUIText(InputManeger.Instance.Key[KeyNo].ToString());
    }
   
    public void OnClick()
    {
        Change_key.gameObject.SetActive(true);
        Change_key.KeyChack(KeyNo);
    }
}
