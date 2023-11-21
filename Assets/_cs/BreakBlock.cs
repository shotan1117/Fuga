using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{
    public bool isBreak;
    // Start is called before the first frame update
    void Start()
    {
        isBreak = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBreak)
        { 
            Destroy(this.gameObject);
            Debug.Log("trueÇ…Ç»Ç¡ÇΩÅI");
        }
       
        
    }


}
