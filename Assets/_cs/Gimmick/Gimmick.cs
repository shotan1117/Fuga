using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick : MonoBehaviour
{
    [SerializeField]
    private int myItemNo;

    public int MyItemNo
    {  get { return myItemNo; } }
    [SerializeField]
    private GameObject Item;

    [SerializeField]
    AudioSource Audio;

    [SerializeField]
    Animator openandclose;

    [SerializeField]
     AudioClip Clip;
    // Start is called before the first frame update

    public void UseObject(int itemNo)
    {
        if (itemNo == MyItemNo)
        {
            Destroy(this.gameObject);
            //アイテムが入っていればアイテム生成
            if (Item != null)
            {
                Instantiate(Item, transform.position, Quaternion.identity);
            }
            //サウンドが入っていればサウンドを鳴らす
            if(Audio != null)
            {
                Audio.PlayOneShot(Clip);
            }

            if(openandclose != null)
            {
                openandclose.Play("Opening");
            }
        }  
    }
   


}
