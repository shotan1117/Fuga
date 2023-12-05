using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick : MonoBehaviour
{
    [SerializeField]
    private int ThisItemNo;
    // Start is called before the first frame update

    public void UseObject(int itemNo)
    {
        if (itemNo == ThisItemNo)
        {
            Destroy(this.gameObject);
        }
    }
}
