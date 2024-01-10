using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Bindings : MonoBehaviour
{
    public Text textUI;
    [SerializeField]
    private KeyCode Defaul_Key_Bindings;
    [SerializeField]
    private int KeyNo;

    [SerializeField] private InputManeger _actionRef;
    // Start is called before the first frame update
    void Start()
    {
        //textUI.text =;
       // _actionRef.Disable();
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void OnClick()
    {
        Debug.Log("a");
    }
}
