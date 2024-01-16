using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Change_Image : MonoBehaviour
{
    private endText owata;
    private Image image;
    public Sprite newSprite;
    // Start is called before the first frame update
    void Start()
    {
        owata = GameObject.Find("Ending_Text").GetComponent<endText>();
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(owata != null && owata.ii == 5) 
        {
            //‰æ‘œ‚ÌØ‚è‘Ö‚¦
            image.sprite = newSprite;
        }
    }
}
