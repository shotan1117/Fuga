using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick : MonoBehaviour
{
    [SerializeField]
    private int MyItemNo;

    [SerializeField]
    private GameObject Item;
    // Start is called before the first frame update

    public void UseObject(int itemNo)
    {
        if (itemNo == MyItemNo)
        {
            Destroy(this.gameObject);
            if (Item != null)
            {
                Instantiate(Item, transform.position, Quaternion.identity);
            }
        }  
    }
}
