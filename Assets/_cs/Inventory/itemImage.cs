using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemImage : MonoBehaviour
{
    public ItemObject item;
    public Image[] i;
    public int num = 0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponent<Image>().sprite=i[num].sprite;
    }

   
}
