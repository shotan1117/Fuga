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
        //������
        key.Add(KeyCode.W);       //�O�i
        key.Add(KeyCode.S);       //���
        key.Add(KeyCode.A);       //���ړ�
        key.Add(KeyCode.D);       //�E�ړ�
        key.Add(KeyCode.E);       //�C���x���g��
        key.Add(KeyCode.Mouse0);  //�A�C�e�������/�g��
        key.Add(KeyCode.F1);  �@�@//�L�[�R���t�B�O
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

    //�ړ�
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
