using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick : MonoBehaviour
{
    [SerializeField]
    private int MyItemNo;

    [SerializeField]
    private GameObject Item;

    [SerializeField]
    AudioSource Audio;

    [SerializeField]
     AudioClip Clip;
    // Start is called before the first frame update

    public void UseObject(int itemNo)
    {
        if (itemNo == MyItemNo)
        {
            Destroy(this.gameObject);
            //�A�C�e���������Ă���΃A�C�e������
            if (Item != null)
            {
                Instantiate(Item, transform.position, Quaternion.identity);
            }
            //�T�E���h�������Ă���΃T�E���h��炷
            if(Audio != null)
            {
                Audio.PlayOneShot(Clip);
            }
        }  
    }
}
