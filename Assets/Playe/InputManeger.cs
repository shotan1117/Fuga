using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManeger : MonoBehaviour
{
    public static InputManeger Instance;
    List<KeyCode> key = new List<KeyCode>();
    public List<KeyCode> Key  { get { return key; } }
    // Start is called before the first frame update
    private void Awake()
    {
        //初期化
        key.Add(KeyCode.W);       //前進
        key.Add(KeyCode.S);       //後退
        key.Add(KeyCode.A);       //左移動
        key.Add(KeyCode.D);       //右移動
        key.Add(KeyCode.E);       //インベントリ
        key.Add(KeyCode.Mouse0);  //アイテムを取る/使う
        key.Add(KeyCode.F1);  　　//キーコンフィグ
        if (Instance == null) 
        { 
        Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //移動
    public float MoveY( float moveY)
    {
        if (Input.GetKey(key[0]))
        {
            moveY = 1;
            Debug.Log("a");
        }
        else if(Input.GetKey(key[1]))
        {
            moveY = -1;
        }
        else
        {
            moveY = 0;
        }
        return moveY;
    }

    public float MoveX(float moveX)
    {
        if (Input.GetKey(key[3]))
        {
            moveX = 1;
        }
        else if (Input.GetKey(key[2]))
        {
            moveX = -1;
        }
        else
        {
            moveX = 0;
        }
        return moveX;
    }
}
